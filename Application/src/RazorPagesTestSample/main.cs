// create new .devcontainer
// add the following to the .devcontainer.json file
// add the following code to the devcontainer.json file

{
	"name": "C# (.NET)",
	"image": "mcr.microsoft.com/devcontainers/dotnet:0-6.0",
	"features": {
		"ghcr.io/devcontainers/features/azure-cli:1": {
			"installBicep": true,
			"version": "latest"
		}
	}
}

