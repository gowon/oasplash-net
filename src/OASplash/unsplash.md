# Unsplash API AutoRest Client

This client is auto-generated using Microsoft's AutoRest tool.

> see <https://aka.ms/autorest>

```yaml
input-file: ..\..\spec\unsplash.yml

csharp:
  namespace: OASplash.Client
  output-folder: Client
  override-client-name: UnsplashClient
  payload-flattening-threshold: 2
  add-credentials: true
  clear-output-folder: true
  max-comment-columns: 80           # multiline comments shall not be wider than 80 characters
  client-side-validation: false     # disable client side validation
  enable-xml: true                  # enable experimental XML serialization support
```

> see <https://github.com/Azure/autorest/blob/master/docs/user/command-line-interface.md>

## How to Update This Client

### Install AutoRest

Installing AutoRest on Windows, MacOS or Linux involves two steps:

1. __Install [Node.js](https://nodejs.org/en/)__ (LTS HIGHLY RECOMENDED)
2. __Install AutoRest__ using `npm`

```powershell
# Depending on your configuration you may need to be elevated or root to run this. (on OSX/Linux use 'sudo' )
npm install -g autorest
```

### Updating AutoRest
  
To update AutoRest if you have previous versions installed, please run:

```powershell
autorest --latest
```

or

```powershell
# Removes all other versions and installs the latest
autorest --reset
```

For more information, run  `autorest --help`
