# CreatingProjectIssue

This repo contains a repro project demonstrating the issue reported with Visual Studio 2022 preview version.
The problem appears to be that the "Creating project ..." dialog is set as a topmost window and so appears in front of other (custom) dialogs displayed as part of the project creation process.

In the image below, you can see that the custom Windows Forms dialog (containing the submit button) is behind the "Creating project ..." dialog and can't be brought in front of it.

![image](https://user-images.githubusercontent.com/189547/145212047-a311d722-cf1a-4ced-87dc-199eeb2dc9da.png)

## Repro steps

1. Open the project in Visual Studio 2022.
2. Set the **Startup Project** to be `MyProjectWizard`
3. Debug in the **Current** release version (v17.0.2)
4. Create a new project with the new template (search "myprojecttemplate" to find it) and see that the custom dialog is not obscured. (The "Creating project..." dialog may not even be visible.)
5. Close Experimental instance.
6. Debug the project in the **Preview** version of VS2022 (v17.10 Preview 1.1)
7. Create a new project with the new template and see that the "Creating project..." dialog is always on top and covers the custom dialog. (Try moving the two dialogs to see that one always obscures the other.)

This repro is based on the sample from the offical docs (https://docs.microsoft.com/en-us/visualstudio/extensibility/how-to-use-wizards-with-project-templates?view=vs-2022) but modified to work with VS2022.

This is a highly simplified version of adding a custom dialog to the new project wizard. In the real project the dialog is much larger and centered in the screen, this means the "Creating project ..." dialog is created over the center of the dialog that the user needs to interact with. It's _not good_ that the user is forced to move dialogs around the screen to be able to use them.
