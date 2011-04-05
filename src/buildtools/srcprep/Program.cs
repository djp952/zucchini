using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace srcprep
{
	/// <summary>
	/// SRCPREP is a quick and dirty utility that prepares the source
	/// tree for distribution by removing all of the Visual Source Safe
	/// binding information from all projects, and cleaning up some
	/// addition things as they arise as distribution issues.
	/// </summary>
	class Program
	{
		private const string SOLUTION_REGEX = @"\t*(GlobalSection\(SourceCodeControl\)).*?(EndGlobalSection)[\r\n]*";
		private const string SCC_REGEX = "\\t*Scc.*=.*\"SAK\"[\\r\\n]*";
		private const string SCC_REGEX2 = "\\t*<Scc.*SAK.*>[\\r\\n]*";

		/// <summary>
		/// Application entry point
		/// </summary>
		static void Main()
		{
			DirectoryInfo root = new DirectoryInfo(Environment.CurrentDirectory);

			// Set all files as normal in the entire tree
			UnAttribFolder(root);

			// Remove all Visual Source Safe "SCC" files
			PurgeFileSpec(root, "*.SCC");
			PurgeFileSpec(root, "*.VSSSCC");
			PurgeFileSpec(root, "*.VSPSCC");

			// Remove all temporary VS.NET files
			PurgeFileSpec(root, "*.SUO");
			PurgeFileSpec(root, "*.NCB");
			PurgeFileSpec(root, "*.USER");

			// Remove intermediate folders
			PurgeFolderSpec(root, "DEBUG");
			PurgeFolderSpec(root, "RELEASE");
			PurgeFolderSpec(root, "OBJ");

			// Remove SourceSafe bindings from all Visual Studio Solution files
			PurgeSolutionBindings(root);

			// Remove SourceSafe bindings from all Visual Studio Project files
			PurgeProjectBindings(root, "*.VCPROJ");
			PurgeProjectBindings(root, "*.CSPROJ");
			PurgeProjectBindings(root, "*.VBPROJ");
			PurgeProjectBindings(root, "*.VJPROJ");
		}

		/// <summary>
		/// Sets all files and folders underneath the specified folder as Normal
		/// </summary>
		/// <param name="folder">The current folder to be processed</param>
		private static void UnAttribFolder(DirectoryInfo folder)
		{
			folder.Attributes = FileAttributes.Normal;
			foreach (FileInfo file in folder.GetFiles()) file.Attributes = FileAttributes.Normal;
			foreach (DirectoryInfo subfolder in folder.GetDirectories()) UnAttribFolder(subfolder);
		}

		/// <summary>
		/// Recursively removes all files with the specified filespec
		/// </summary>
		/// <param name="folder">The current folder to be processed</param>
		/// <param name="filespec">The file specification to delete all instances of</param>
		private static void PurgeFileSpec(DirectoryInfo folder, string filespec)
		{
			foreach (FileInfo file in folder.GetFiles(filespec)) file.Delete();
			foreach (DirectoryInfo subfolder in folder.GetDirectories()) PurgeFileSpec(subfolder, filespec);
		}

		/// <summary>
		/// Recursively removes all folders with the specified folderspec
		/// </summary>
		/// <param name="folder">The current folder to be processed</param>
		/// <param name="folderspec">The folder specification to delete all instances of</param>
		private static void PurgeFolderSpec(DirectoryInfo folder, string folderspec)
		{
			foreach (DirectoryInfo subfolder in folder.GetDirectories()) PurgeFolderSpec(subfolder, folderspec);
			foreach (DirectoryInfo subfolder in folder.GetDirectories(folderspec)) subfolder.Delete(true);
		}

		/// <summary>
		/// Removes all Visual Source Safe bindings from .SLN files in the target folder
		/// </summary>
		/// <param name="folder">The current folder to be processed</param>
		private static void PurgeSolutionBindings(DirectoryInfo folder)
		{
			foreach (FileInfo file in folder.GetFiles("*.SLN"))
			{
				using (StreamReader reader = file.OpenText())
				{
					// Note that we need to preserve the original file encoding
					// otherwise Visual Studio can get quite upset with us

					string contents = reader.ReadToEnd();
					Encoding sourceEncoding = reader.CurrentEncoding;
					reader.Close();

					Match match = Regex.Match(contents, SOLUTION_REGEX, RegexOptions.Singleline | RegexOptions.IgnoreCase);
					if (match.Success)
					{
						StringBuilder newfile = new StringBuilder();
						newfile.Append(contents.Substring(0, match.Index));
						newfile.Append(contents.Substring(match.Index + match.Length));

						using (StreamWriter writer = new StreamWriter(File.Create(file.FullName), sourceEncoding))
						{
							writer.Write(newfile.ToString());
						}
					}
				}
			}

			foreach (DirectoryInfo subfolder in folder.GetDirectories()) PurgeSolutionBindings(subfolder);
		}

		/// <summary>
		/// Removes all Visual Source Safe bindings from .V?PROJ files in the target folder
		/// </summary>
		/// <param name="folder">The current folder to be processed</param>
		private static void PurgeProjectBindings(DirectoryInfo folder, string filespec)
		{
			foreach (FileInfo file in folder.GetFiles(filespec))
			{
				using (StreamReader reader = file.OpenText())
				{
					// Note that we need to preserve the original file encoding
					// otherwise Visual Studio can get quite upset with us

					string contents = reader.ReadToEnd();
					Encoding sourceEncoding = reader.CurrentEncoding;
					reader.Close();

					if (contents.Contains("SccProjectName"))
					{
						contents = Regex.Replace(contents, SCC_REGEX, "");
						contents = Regex.Replace(contents, SCC_REGEX2, "");

						using (StreamWriter writer = new StreamWriter(File.Create(file.FullName), sourceEncoding))
						{
							writer.Write(contents);
						}
					}
				}
			}

			foreach (DirectoryInfo subfolder in folder.GetDirectories()) PurgeProjectBindings(subfolder, filespec);
		}
	}
}
