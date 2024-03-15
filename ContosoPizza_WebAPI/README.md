## For Issue install gloabl httprepl on MacOS

To install the `Microsoft.dotnet-httprepl` tool on macOS using the .NET CLI, follow these steps:

1. **Open Terminal**: You can find the Terminal app in your Applications folder under Utilities, or you can search for it using Spotlight.

2. **Run the Installation Command**: In the Terminal, type the following command and press Enter to install the HttpRepl tool:

   ```bash
   dotnet tool install -g Microsoft.dotnet-httprepl
   ```

3. **Update Your PATH**: After installing the tool, you need to ensure that the directory containing the tool is added to your system's PATH environment variable. This allows you to run the tool from any directory in the Terminal. To update your PATH, run the following command in the Terminal:

   ```bash
   export PATH="$HOME/.dotnet/tools:$PATH"
   ```

4. **Make the PATH Update Persistent** (optional but recommended): The previous command only sets the PATH variable for the current Terminal session. To make this change permanent, you need to add the `export` command to your shell profile file (like `.bash_profile`, `.bashrc`, or `.zshrc` depending on your shell). You can do this by running the following command in the Terminal:

   ```bash
   echo 'export PATH="$HOME/.dotnet/tools:$PATH"' >> ~/.bash_profile
   ```

   If you are using Zsh (the default shell on newer macOS versions), replace `~/.bash_profile` with `~/.zshrc`.

5. **Restart Terminal**: For the changes to take effect, you may need to close and reopen the Terminal, or you can reload the profile with the command `source ~/.bash_profile` (or `source ~/.zshrc` for Zsh).

After completing these steps, you should be able to run the `httprepl` command from any directory in your Terminal to start using the HTTP REPL tool.
