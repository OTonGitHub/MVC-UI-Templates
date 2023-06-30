<strong>Author</strong> : Ifhaam </br>
<strong>Date</strong>   : 26th June 2023

# Notes
	- all projects are in net6.0-lts
	- if necessary other net versioned projs have net version append to project name,
		- example: SMTPEmail-NET45 -> .NET Framework 4.5
	- .NET versions above 4.6.2 should run in VS 2022, no issues,
	- to however create projects from version net6.0 and below, would be a bit tricky, CLI is supported for .NET Core only.
	- for SDKs no longer available officially, such as NET45,
		- you may build against the reference libraries, added as a dependency, or
		- download reference assembly from nuget gallery, extract contents, and replace existing system binaries in C:\ProgramFiles\ReferenceAssemblies
	- for running .NET Framework projects on MAC, use
		- mono project runtime, or
		- vm ware, or
		- parallals
	- for overall better MAC and Linux experience, prefer cross platform, tools
		- MS released new C# dev kit extension few days ago, June 2023, for VS Code,
		- JB Rider works great too, message me for free 1 year license
	- if using VSC, use CLI, will include all required commands below,
	- refrain from using reverse poco model scaffolding tools, instead use in-memory repository, to use template as a pocket tool
	- for identity server templates, will add easier db solution on sqlite or something similar.
	- if you want to add any fixes/updates/projects, re-init as git repository, commit changes, and provide zip folder,\n
	  i will merge and update provided cloud folder with version, author and commit changes

# Repacking Project as a Library
	- ideally, onchange functions must be bound to category value of selected item
	- if category value remains the same, next list items will remian the same
	- a more advanced way would be to have multiple category values in each item,
	- which will categoryically populate each select list
	- but such a mean is not necessary, as it destroys the point of a select list in teh first place, 
	- ideally it should not have so many items in each list that each item categorically populates or removes so manyh items from the next list that it may affect performance. Hence, the idea of attaching a single category per item in each select list is the less troublesome and easy to use approach even for the programmer using the library.
	- However, the idea could still be used as an extension while keeping the simplicity of the library so is not necessarily entirely unnecessary to add in the future.