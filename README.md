# Build with Advantage - AI-Powered Web Application

A .NET Framework 4.8 web application integrating Azure OpenAI and Cognitive Services for AI-powered features.

## Features

- Chat Interface (Azure OpenAI GPT-4)
- Image Generation (DALL-E) 
- Image Captioning (Azure Vision)
- Code Snippet Generation
- Document Translation
- File Management with Azure Blob Storage

## Configuration 

Required Azure services:
- Azure OpenAI
- Computer Vision  
- Translator
- Blob Storage

Environment variables needed in web.config:
```xml
<add key="AzureOpenAI" value="your_key" />
<add key="AzureVision" value="your_key" />
<add key="AzureTranslator" value="your_key" />
<add key="AzureStorage" value="your_connection_string" />

## Tech Stack

- ASP.NET MVC 5.3
- Azure Services (OpenAI, Vision, Translator, Blob Storage)
- Unity for DI
- Bootstrap UI
- jQuery/AJAX

## Setup

1. Clone repository
2. Add Azure service connection strings to web.config
3. Restore NuGet packages
4. Build and run

## Project Structure

Folder PATH listing for volume OS
Volume serial number is A697-1488
C:.
|   .gitattributes
|   .gitignore
|   Build with Advantage.csproj
|   Build with Advantage.csproj.user
|   Build with Advantage_v2.sln
|   packages.config
|   project_structure.txt
|   UnityConfig.cs
|   UpgradeLog.htm
|   UpgradeLog2.htm
|   UpgradeLog3.htm
|   UpgradeLog4.htm
|   UpgradeLog5.htm
|   UpgradeLog6.htm
|   web.config
|   web.Debug.config
|   web.Release.config
|   
+---.github
|   \---workflows
+---AdvantageAI_Server
|   |   AdvantageAIService.cs
|   |   AdvantageAI_Server.csproj
|   |   AdvantageAI_Server.csproj.user
|   |   app.config
|   |   Microsoft.CodeDom.Providers.DotNetCompilerPlatform.dll
|   |   Microsoft.CodeDom.Providers.DotNetCompilerPlatform.xml
|   |   packages.config
|   |   web.config
|   |   web.Debug.config
|   |   web.Release.config
|   |   
|   +---App_Start
|   |       UnityConfig.cs
|   |       UnityWebApiActivator.cs
|   |       UnityWebApiConfig.cs
|   |       
|   +---Azure
|   |   \---Storage
|   +---bin
|   |   |   AdvantageAI_Server.dll
|   |   |   AdvantageAI_Server.dll.config
|   |   |   AdvantageAI_Server.pdb
|   |   |   Antlr3.Runtime.dll
|   |   |   Antlr3.Runtime.pdb
|   |   |   Azure.AI.OpenAI.dll
|   |   |   Azure.AI.Translation.Document.dll
|   |   |   Azure.AI.Translation.Document.xml
|   |   |   Azure.AI.Translation.Text.dll
|   |   |   Azure.AI.Translation.Text.xml
|   |   |   Azure.Core.dll
|   |   |   Azure.Core.xml
|   |   |   Azure.Data.Tables.dll
|   |   |   Azure.Data.Tables.xml
|   |   |   Azure.Identity.dll
|   |   |   Azure.Identity.xml
|   |   |   Azure.ResourceManager.Compute.dll
|   |   |   Azure.ResourceManager.Compute.xml
|   |   |   Azure.ResourceManager.dll
|   |   |   Azure.ResourceManager.KeyVault.dll
|   |   |   Azure.ResourceManager.KeyVault.xml
|   |   |   Azure.ResourceManager.TrafficManager.dll
|   |   |   Azure.ResourceManager.TrafficManager.xml
|   |   |   Azure.ResourceManager.xml
|   |   |   Azure.Security.KeyVault.Certificates.dll
|   |   |   Azure.Security.KeyVault.Certificates.xml
|   |   |   Azure.Storage.Blobs.dll
|   |   |   Azure.Storage.Blobs.xml
|   |   |   Azure.Storage.Common.dll
|   |   |   Azure.Storage.Common.xml
|   |   |   Azure.Storage.Files.Shares.dll
|   |   |   Azure.Storage.Files.Shares.xml
|   |   |   Azure.Storage.Queues.dll
|   |   |   Azure.Storage.Queues.xml
|   |   |   Microsoft.AspNetCore.Antiforgery.dll
|   |   |   Microsoft.AspNetCore.Antiforgery.xml
|   |   |   Microsoft.AspNetCore.Authentication.Abstractions.dll
|   |   |   Microsoft.AspNetCore.Authentication.Abstractions.xml
|   |   |   Microsoft.AspNetCore.Authentication.Core.dll
|   |   |   Microsoft.AspNetCore.Authentication.Core.xml
|   |   |   Microsoft.AspNetCore.Authorization.dll
|   |   |   Microsoft.AspNetCore.Authorization.Policy.dll
|   |   |   Microsoft.AspNetCore.Authorization.Policy.xml
|   |   |   Microsoft.AspNetCore.Authorization.xml
|   |   |   Microsoft.AspNetCore.Cryptography.Internal.dll
|   |   |   Microsoft.AspNetCore.Cryptography.Internal.xml
|   |   |   Microsoft.AspNetCore.DataProtection.Abstractions.dll
|   |   |   Microsoft.AspNetCore.DataProtection.Abstractions.xml
|   |   |   Microsoft.AspNetCore.DataProtection.dll
|   |   |   Microsoft.AspNetCore.DataProtection.xml
|   |   |   Microsoft.AspNetCore.Diagnostics.Abstractions.dll
|   |   |   Microsoft.AspNetCore.Diagnostics.Abstractions.xml
|   |   |   Microsoft.AspNetCore.Hosting.Abstractions.dll
|   |   |   Microsoft.AspNetCore.Hosting.Abstractions.xml
|   |   |   Microsoft.AspNetCore.Hosting.Server.Abstractions.dll
|   |   |   Microsoft.AspNetCore.Hosting.Server.Abstractions.xml
|   |   |   Microsoft.AspNetCore.Html.Abstractions.dll
|   |   |   Microsoft.AspNetCore.Html.Abstractions.xml
|   |   |   Microsoft.AspNetCore.Http.Abstractions.dll
|   |   |   Microsoft.AspNetCore.Http.Abstractions.xml
|   |   |   Microsoft.AspNetCore.Http.dll
|   |   |   Microsoft.AspNetCore.Http.Extensions.dll
|   |   |   Microsoft.AspNetCore.Http.Extensions.xml
|   |   |   Microsoft.AspNetCore.Http.Features.dll
|   |   |   Microsoft.AspNetCore.Http.Features.xml
|   |   |   Microsoft.AspNetCore.Http.xml
|   |   |   Microsoft.AspNetCore.JsonPatch.dll
|   |   |   Microsoft.AspNetCore.JsonPatch.xml
|   |   |   Microsoft.AspNetCore.Mvc.Abstractions.dll
|   |   |   Microsoft.AspNetCore.Mvc.Abstractions.xml
|   |   |   Microsoft.AspNetCore.Mvc.Core.dll
|   |   |   Microsoft.AspNetCore.Mvc.Core.xml
|   |   |   Microsoft.AspNetCore.Mvc.DataAnnotations.dll
|   |   |   Microsoft.AspNetCore.Mvc.DataAnnotations.xml
|   |   |   Microsoft.AspNetCore.Mvc.Formatters.Json.dll
|   |   |   Microsoft.AspNetCore.Mvc.Formatters.Json.xml
|   |   |   Microsoft.AspNetCore.Mvc.ViewFeatures.dll
|   |   |   Microsoft.AspNetCore.Mvc.ViewFeatures.xml
|   |   |   Microsoft.AspNetCore.ResponseCaching.Abstractions.dll
|   |   |   Microsoft.AspNetCore.ResponseCaching.Abstractions.xml
|   |   |   Microsoft.AspNetCore.Routing.Abstractions.dll
|   |   |   Microsoft.AspNetCore.Routing.Abstractions.xml
|   |   |   Microsoft.AspNetCore.Routing.dll
|   |   |   Microsoft.AspNetCore.Routing.xml
|   |   |   Microsoft.AspNetCore.WebUtilities.dll
|   |   |   Microsoft.AspNetCore.WebUtilities.xml
|   |   |   Microsoft.Bcl.AsyncInterfaces.dll
|   |   |   Microsoft.Bcl.AsyncInterfaces.xml
|   |   |   Microsoft.Bcl.HashCode.dll
|   |   |   Microsoft.Bcl.HashCode.xml
|   |   |   Microsoft.Bcl.TimeProvider.dll
|   |   |   Microsoft.Bcl.TimeProvider.xml
|   |   |   Microsoft.CodeDom.Providers.DotNetCompilerPlatform.dll
|   |   |   Microsoft.CodeDom.Providers.DotNetCompilerPlatform.xml
|   |   |   Microsoft.Configuration.ConfigurationBuilders.Base.dll
|   |   |   Microsoft.Configuration.ConfigurationBuilders.Base.xml
|   |   |   Microsoft.Configuration.ConfigurationBuilders.UserSecrets.dll
|   |   |   Microsoft.Configuration.ConfigurationBuilders.UserSecrets.xml
|   |   |   Microsoft.DotNet.PlatformAbstractions.dll
|   |   |   Microsoft.Extensions.Azure.dll
|   |   |   Microsoft.Extensions.Azure.xml
|   |   |   Microsoft.Extensions.Configuration.Abstractions.dll
|   |   |   Microsoft.Extensions.Configuration.Abstractions.xml
|   |   |   Microsoft.Extensions.Configuration.Binder.dll
|   |   |   Microsoft.Extensions.Configuration.Binder.xml
|   |   |   Microsoft.Extensions.Configuration.dll
|   |   |   Microsoft.Extensions.DependencyInjection.Abstractions.dll
|   |   |   Microsoft.Extensions.DependencyInjection.Abstractions.xml
|   |   |   Microsoft.Extensions.DependencyModel.dll
|   |   |   Microsoft.Extensions.Diagnostics.Abstractions.dll
|   |   |   Microsoft.Extensions.Diagnostics.Abstractions.xml
|   |   |   Microsoft.Extensions.FileProviders.Abstractions.dll
|   |   |   Microsoft.Extensions.FileProviders.Abstractions.xml
|   |   |   Microsoft.Extensions.Hosting.Abstractions.dll
|   |   |   Microsoft.Extensions.Hosting.Abstractions.xml
|   |   |   Microsoft.Extensions.Localization.Abstractions.dll
|   |   |   Microsoft.Extensions.Localization.Abstractions.xml
|   |   |   Microsoft.Extensions.Localization.dll
|   |   |   Microsoft.Extensions.Localization.xml
|   |   |   Microsoft.Extensions.Logging.Abstractions.dll
|   |   |   Microsoft.Extensions.Logging.Abstractions.xml
|   |   |   Microsoft.Extensions.Logging.dll
|   |   |   Microsoft.Extensions.ObjectPool.dll
|   |   |   Microsoft.Extensions.ObjectPool.xml
|   |   |   Microsoft.Extensions.Options.dll
|   |   |   Microsoft.Extensions.Options.xml
|   |   |   Microsoft.Extensions.Primitives.dll
|   |   |   Microsoft.Extensions.Primitives.xml
|   |   |   Microsoft.Extensions.WebEncoders.dll
|   |   |   Microsoft.Extensions.WebEncoders.xml
|   |   |   Microsoft.Graph.Core.dll
|   |   |   Microsoft.Graph.Core.xml
|   |   |   Microsoft.Graph.dll
|   |   |   Microsoft.Graph.xml
|   |   |   Microsoft.Identity.Client.dll
|   |   |   Microsoft.Identity.Client.Extensions.Msal.dll
|   |   |   Microsoft.Identity.Client.Extensions.Msal.xml
|   |   |   Microsoft.Identity.Client.xml
|   |   |   Microsoft.IdentityModel.Abstractions.dll
|   |   |   Microsoft.IdentityModel.Abstractions.xml
|   |   |   Microsoft.IdentityModel.JsonWebTokens.dll
|   |   |   Microsoft.IdentityModel.JsonWebTokens.xml
|   |   |   Microsoft.IdentityModel.Logging.dll
|   |   |   Microsoft.IdentityModel.Logging.xml
|   |   |   Microsoft.IdentityModel.Protocols.dll
|   |   |   Microsoft.IdentityModel.Protocols.OpenIdConnect.dll
|   |   |   Microsoft.IdentityModel.Protocols.OpenIdConnect.xml
|   |   |   Microsoft.IdentityModel.Protocols.xml
|   |   |   Microsoft.IdentityModel.Tokens.dll
|   |   |   Microsoft.IdentityModel.Tokens.xml
|   |   |   Microsoft.IdentityModel.Validators.dll
|   |   |   Microsoft.IdentityModel.Validators.xml
|   |   |   Microsoft.Kiota.Abstractions.dll
|   |   |   Microsoft.Kiota.Abstractions.xml
|   |   |   Microsoft.Kiota.Authentication.Azure.dll
|   |   |   Microsoft.Kiota.Authentication.Azure.xml
|   |   |   Microsoft.Kiota.Http.HttpClientLibrary.dll
|   |   |   Microsoft.Kiota.Http.HttpClientLibrary.xml
|   |   |   Microsoft.Kiota.Serialization.Form.dll
|   |   |   Microsoft.Kiota.Serialization.Form.xml
|   |   |   Microsoft.Kiota.Serialization.Json.dll
|   |   |   Microsoft.Kiota.Serialization.Json.xml
|   |   |   Microsoft.Kiota.Serialization.Multipart.dll
|   |   |   Microsoft.Kiota.Serialization.Multipart.xml
|   |   |   Microsoft.Kiota.Serialization.Text.dll
|   |   |   Microsoft.Kiota.Serialization.Text.xml
|   |   |   Microsoft.Net.Http.Headers.dll
|   |   |   Microsoft.Net.Http.Headers.xml
|   |   |   Microsoft.Owin.dll
|   |   |   Microsoft.Owin.xml
|   |   |   Microsoft.Web.Infrastructure.dll
|   |   |   Microsoft.Win32.Registry.dll
|   |   |   Newtonsoft.Json.Bson.dll
|   |   |   Newtonsoft.Json.Bson.pdb
|   |   |   Newtonsoft.Json.Bson.xml
|   |   |   Newtonsoft.Json.dll
|   |   |   Newtonsoft.Json.xml
|   |   |   NLog.dll
|   |   |   NLog.xml
|   |   |   Owin.dll
|   |   |   RestSharp.dll
|   |   |   RestSharp.xml
|   |   |   Std.UriTemplate.dll
|   |   |   System.Buffers.dll
|   |   |   System.ClientModel.dll
|   |   |   System.ClientModel.xml
|   |   |   System.Collections.Immutable.dll
|   |   |   System.Collections.Immutable.xml
|   |   |   System.ComponentModel.Annotations.dll
|   |   |   System.Configuration.ConfigurationManager.dll
|   |   |   System.Configuration.ConfigurationManager.xml
|   |   |   System.Diagnostics.DiagnosticSource.dll
|   |   |   System.Diagnostics.DiagnosticSource.xml
|   |   |   System.IdentityModel.Tokens.Jwt.dll
|   |   |   System.IdentityModel.Tokens.Jwt.xml
|   |   |   System.IO.dll
|   |   |   System.IO.Hashing.dll
|   |   |   System.IO.Pipelines.dll
|   |   |   System.IO.Pipelines.xml
|   |   |   System.Memory.Data.dll
|   |   |   System.Memory.dll
|   |   |   System.Net.Http.dll
|   |   |   System.Net.Http.Formatting.dll
|   |   |   System.Net.Http.Formatting.xml
|   |   |   System.Net.Http.WinHttpHandler.dll
|   |   |   System.Net.Http.WinHttpHandler.xml
|   |   |   System.Numerics.Vectors.dll
|   |   |   System.Numerics.Vectors.xml
|   |   |   System.Runtime.CompilerServices.Unsafe.dll
|   |   |   System.Runtime.dll
|   |   |   System.Runtime.InteropServices.RuntimeInformation.dll
|   |   |   System.Security.AccessControl.dll
|   |   |   System.Security.AccessControl.xml
|   |   |   System.Security.Cryptography.Algorithms.dll
|   |   |   System.Security.Cryptography.Encoding.dll
|   |   |   System.Security.Cryptography.Primitives.dll
|   |   |   System.Security.Cryptography.ProtectedData.dll
|   |   |   System.Security.Cryptography.ProtectedData.xml
|   |   |   System.Security.Cryptography.X509Certificates.dll
|   |   |   System.Security.Cryptography.Xml.dll
|   |   |   System.Security.Cryptography.Xml.xml
|   |   |   System.Security.Permissions.dll
|   |   |   System.Security.Permissions.xml
|   |   |   System.Security.Principal.Windows.dll
|   |   |   System.Security.Principal.Windows.xml
|   |   |   System.Text.Encodings.Web.dll
|   |   |   System.Text.Encodings.Web.xml
|   |   |   System.Text.Json.dll
|   |   |   System.Text.Json.xml
|   |   |   System.Threading.Tasks.Extensions.dll
|   |   |   System.ValueTuple.dll
|   |   |   System.ValueTuple.xml
|   |   |   System.Web.Helpers.dll
|   |   |   System.Web.Helpers.xml
|   |   |   System.Web.Http.dll
|   |   |   System.Web.Http.WebHost.dll
|   |   |   System.Web.Http.WebHost.xml
|   |   |   System.Web.Http.xml
|   |   |   System.Web.Mvc.dll
|   |   |   System.Web.Mvc.xml
|   |   |   System.Web.Razor.dll
|   |   |   System.Web.WebPages.Deployment.dll
|   |   |   System.Web.WebPages.dll
|   |   |   System.Web.WebPages.Razor.dll
|   |   |   Unity.Abstractions.dll
|   |   |   Unity.Abstractions.pdb
|   |   |   Unity.AspNet.WebApi.dll
|   |   |   Unity.AspNet.WebApi.pdb
|   |   |   Unity.AspNet.WebApi.xml
|   |   |   Unity.Container.dll
|   |   |   Unity.Container.pdb
|   |   |   Unity.Mvc5.dll
|   |   |   WebActivatorEx.dll
|   |   |   
|   |   \---roslyn
|   |           csc.exe
|   |           csc.exe.config
|   |           csc.rsp
|   |           csi.exe
|   |           csi.exe.config
|   |           csi.rsp
|   |           Microsoft.Build.Tasks.CodeAnalysis.dll
|   |           Microsoft.CodeAnalysis.CSharp.dll
|   |           Microsoft.CodeAnalysis.CSharp.Scripting.dll
|   |           Microsoft.CodeAnalysis.dll
|   |           Microsoft.CodeAnalysis.Scripting.dll
|   |           Microsoft.CodeAnalysis.VisualBasic.dll
|   |           Microsoft.CSharp.Core.targets
|   |           Microsoft.DiaSymReader.Native.amd64.dll
|   |           Microsoft.DiaSymReader.Native.x86.dll
|   |           Microsoft.Managed.Core.targets
|   |           Microsoft.VisualBasic.Core.targets
|   |           Microsoft.Win32.Primitives.dll
|   |           System.AppContext.dll
|   |           System.Collections.Immutable.dll
|   |           System.Console.dll
|   |           System.Diagnostics.DiagnosticSource.dll
|   |           System.Diagnostics.FileVersionInfo.dll
|   |           System.Diagnostics.StackTrace.dll
|   |           System.Globalization.Calendars.dll
|   |           System.IO.Compression.dll
|   |           System.IO.Compression.ZipFile.dll
|   |           System.IO.FileSystem.dll
|   |           System.IO.FileSystem.Primitives.dll
|   |           System.Net.Http.dll
|   |           System.Net.Sockets.dll
|   |           System.Reflection.Metadata.dll
|   |           System.Runtime.InteropServices.RuntimeInformation.dll
|   |           System.Security.Cryptography.Algorithms.dll
|   |           System.Security.Cryptography.Encoding.dll
|   |           System.Security.Cryptography.Primitives.dll
|   |           System.Security.Cryptography.X509Certificates.dll
|   |           System.Text.Encoding.CodePages.dll
|   |           System.Threading.Tasks.Extensions.dll
|   |           System.ValueTuple.dll
|   |           System.Xml.ReaderWriter.dll
|   |           System.Xml.XmlDocument.dll
|   |           System.Xml.XPath.dll
|   |           System.Xml.XPath.XDocument.dll
|   |           vbc.exe
|   |           vbc.exe.config
|   |           vbc.rsp
|   |           VBCSCompiler.exe
|   |           VBCSCompiler.exe.config
|   |           
|   +---Configuration
|   |       ServiceConfig.cs
|   |       
|   +---Connected Services
|   +---ILLink
|   |       ILLink.Descriptors.LibraryBuild.xml
|   |       
|   +---Interfaces
|   |       AdvantageAIService.cs
|   |       CodeGenerationService.cs
|   |       ContentGenerationResult.cs
|   |       IAdvantageAIService.cs
|   |       ICodeGenerationService.cs
|   |       IDalleService.cs
|   |       IImagePromptRequest.cs
|   |       IOpenAIService.cs
|   |       IRetrievalService.cs
|   |       ITranslatorService.cs
|   |       IVisionService.cs
|   |       OpenAIService.cs
|   |       OpenAIServiceBase.cs
|   |       
|   +---Models
|   |   |   ChatRole.cs
|   |   |   DocumentTranslationResult.cs
|   |   |   ImageCaption.cs
|   |   |   TranslationResult.cs
|   |   |   UploadDocument.cs
|   |   |   
|   |   \---Image
|   |           ImagePromptRequest.cs
|   |           ImageResult.cs
|   |           
|   +---obj
|   |   +---Debug
|   |   |   |   .NETFramework,Version=v4.8.AssemblyAttributes.cs
|   |   |   |   Advantag.F6759E17.Up2Date
|   |   |   |   AdvantageAI_Server.csproj.AssemblyReference.cache
|   |   |   |   AdvantageAI_Server.csproj.CoreCompileInputs.cache
|   |   |   |   AdvantageAI_Server.csproj.FileListAbsolute.txt
|   |   |   |   AdvantageAI_Server.dll
|   |   |   |   AdvantageAI_Server.pdb
|   |   |   |   DesignTimeResolveAssemblyReferences.cache
|   |   |   |   DesignTimeResolveAssemblyReferencesInput.cache
|   |   |   |   
|   |   |   \---TempPE
|   |   \---Release
|   |           .NETFramework,Version=v4.8.AssemblyAttributes.cs
|   |           AdvantageAI_Server.csproj.AssemblyReference.cache
|   |           
|   +---Properties
|   |       AssemblyInfo.cs
|   |       serviceDependencies.json
|   |       serviceDependencies.local.json
|   |       serviceDependencies.local.json.user
|   |       Settings.Designer.cs
|   |       Settings.settings
|   |       
|   \---Services
|           ChatCompletionResult.cs
|           
+---AdvantageAI_Web
|   |   favicon.ico
|   |   Global.asax
|   |   Global.asax.cs
|   |   packages.config
|   |   project_structure.txt
|   |   
|   +---App_Start
|   |       BundleConfig.cs
|   |       FilterConfig.cs
|   |       RouteConfig.cs
|   |       WebApiConfig.cs
|   |       
|   +---Content
|   |       bootstrap-grid.css
|   |       bootstrap-grid.css.map
|   |       bootstrap-grid.min.css
|   |       bootstrap-grid.min.css.map
|   |       bootstrap-grid.rtl.css
|   |       bootstrap-grid.rtl.css.map
|   |       bootstrap-grid.rtl.min.css
|   |       bootstrap-grid.rtl.min.css.map
|   |       bootstrap-reboot.css
|   |       bootstrap-reboot.css.map
|   |       bootstrap-reboot.min.css
|   |       bootstrap-reboot.min.css.map
|   |       bootstrap-reboot.rtl.css
|   |       bootstrap-reboot.rtl.css.map
|   |       bootstrap-reboot.rtl.min.css
|   |       bootstrap-reboot.rtl.min.css.map
|   |       bootstrap-utilities.css
|   |       bootstrap-utilities.css.map
|   |       bootstrap-utilities.min.css
|   |       bootstrap-utilities.min.css.map
|   |       bootstrap-utilities.rtl.css
|   |       bootstrap-utilities.rtl.css.map
|   |       bootstrap-utilities.rtl.min.css
|   |       bootstrap-utilities.rtl.min.css.map
|   |       bootstrap.css
|   |       bootstrap.css.map
|   |       bootstrap.min.css
|   |       bootstrap.min.css.map
|   |       bootstrap.rtl.css
|   |       bootstrap.rtl.css.map
|   |       bootstrap.rtl.min.css
|   |       bootstrap.rtl.min.css.map
|   |       Site.css
|   |       
|   +---Controllers
|   |       BlobServiceClients.cs
|   |       BlobServiceClientWrapperBase.cs
|   |       ChatCompletionsOptions.cs
|   |       DalleService.cs
|   |       ErrorController.cs
|   |       HomeController.cs
|   |       ImageCaptionRequest.cs
|   |       LogManager.cs
|   |       RetrievalService.cs
|   |       TranslatorService.cs
|   |       VisionService.cs
|   |       
|   +---Model
|   |   +---AI
|   |   |       ImagePromptRequest.cs
|   |   |       
|   |   +---Chat
|   |   |   |   ChatMessage.cs
|   |   |   |   ChatRequest.cs
|   |   |   |   ChatViewModel.cs
|   |   |   |   GenerateCodeRequest.cs
|   |   |   |   ServiceResponse.cs
|   |   |   |   StreamedChatResponse.cs
|   |   |   |   TranslateRequest.cs
|   |   |   |   
|   |   |   \---AI
|   |   |           AIModel.cs
|   |   |           AIResponse.cs
|   |   |           TranslatorOptions.cs
|   |   |           
|   |   +---Image
|   |   |       ImageCaption.cs
|   |   |       ImagePromptViewModel.cs
|   |   |       ImageViewModel.cs
|   |   |       
|   |   \---ViewModels
|   |           HomeViewModel.cs
|   |           
|   +---Scripts
|   |       bootstrap.bundle.js
|   |       bootstrap.bundle.js.map
|   |       bootstrap.bundle.min.js
|   |       bootstrap.bundle.min.js.map
|   |       bootstrap.esm.js
|   |       bootstrap.esm.js.map
|   |       bootstrap.esm.min.js
|   |       bootstrap.esm.min.js.map
|   |       bootstrap.js
|   |       bootstrap.js.map
|   |       bootstrap.min.js
|   |       bootstrap.min.js.map
|   |       copyToClipboard.js
|   |       jquery-3.6.0.intellisense.js
|   |       jquery-3.6.0.js
|   |       jquery-3.6.0.min.js
|   |       jquery-3.6.0.min.map
|   |       jquery-3.6.0.slim.js
|   |       jquery-3.6.0.slim.min.js
|   |       jquery-3.6.0.slim.min.map
|   |       jquery-3.7.0.intellisense.js
|   |       jquery-3.7.0.js
|   |       jquery-3.7.0.min.js
|   |       jquery-3.7.0.min.map
|   |       jquery-3.7.0.slim.js
|   |       jquery-3.7.0.slim.min.js
|   |       jquery-3.7.0.slim.min.map
|   |       jquery-3.7.1-vsdoc.js
|   |       jquery-3.7.1.js
|   |       jquery-3.7.1.min.js
|   |       jquery-3.7.1.min.map
|   |       jquery-3.7.1.slim.js
|   |       jquery-3.7.1.slim.min.js
|   |       jquery-3.7.1.slim.min.map
|   |       jquery.validate-vsdoc.js
|   |       jquery.validate.js
|   |       jquery.validate.min.js
|   |       jquery.validate.unobtrusive.js
|   |       jquery.validate.unobtrusive.min.js
|   |       modernizr-2.8.3.js
|   |       Prompt.js
|   |       
|   \---Views
|       |   Web.config
|       |   _ViewStart.cshtml
|       |   
|       +---Home
|       |       Chat.cshtml
|       |       GenerateCodeSnippet.cshtml
|       |       GenerateImage.cshtml
|       |       GenerateImageCaption.cshtml
|       |       Index.cshtml
|       |       UploadDocument.cshtml
|       |       
|       \---Shared
|               Error.cshtml
|               _LanguageOptions.cshtml
|               _Layout.cshtml
|               
+---App_Start
|       UnityConfig.cs
|       UnityWebApiActivator.cs
|       
+---Azure
|       Storage.cs
|       
+---bin
|   |   AdvantageAI_Server.dll
|   |   Antlr3.Runtime.dll
|   |   Autofac.dll
|   |   Azure.AI.Translation.Document.dll
|   |   Azure.AI.Translation.Text.dll
|   |   Azure.Core.dll
|   |   Azure.Storage.Blobs.dll
|   |   Azure.Storage.Common.dll
|   |   Microsoft.Azure.Cosmos.Client.dll
|   |   Microsoft.Azure.Cosmos.Core.dll
|   |   Microsoft.Azure.Cosmos.Direct.dll
|   |   Microsoft.Azure.Cosmos.Serialization.HybridRow.dll
|   |   Microsoft.Azure.KeyVault.Core.dll
|   |   Microsoft.Azure.Storage.Blob.dll
|   |   Microsoft.Azure.Storage.Common.dll
|   |   Microsoft.Bcl.AsyncInterfaces.dll
|   |   Microsoft.Bcl.HashCode.dll
|   |   Microsoft.CodeDom.Providers.DotNetCompilerPlatform.dll
|   |   Microsoft.CodeDom.Providers.DotNetCompilerPlatform.xml
|   |   Microsoft.Extensions.Configuration.Abstractions.dll
|   |   Microsoft.Extensions.Configuration.Binder.dll
|   |   Microsoft.Extensions.Configuration.dll
|   |   Microsoft.Extensions.DependencyInjection.Abstractions.dll
|   |   Microsoft.Extensions.DependencyInjection.dll
|   |   Microsoft.Extensions.Logging.Abstractions.dll
|   |   Microsoft.Extensions.Logging.Configuration.dll
|   |   Microsoft.Extensions.Logging.Console.dll
|   |   Microsoft.Extensions.Logging.dll
|   |   Microsoft.Extensions.Options.ConfigurationExtensions.dll
|   |   Microsoft.Extensions.Options.dll
|   |   Microsoft.Extensions.Primitives.dll
|   |   Microsoft.Identity.Client.dll
|   |   Microsoft.IdentityModel.Abstractions.dll
|   |   Microsoft.Owin.dll
|   |   Microsoft.Web.Infrastructure.dll
|   |   Newtonsoft.Json.Bson.dll
|   |   Newtonsoft.Json.dll
|   |   Owin.dll
|   |   System.Buffers.dll
|   |   System.ClientModel.dll
|   |   System.Collections.Immutable.dll
|   |   System.Configuration.ConfigurationManager.dll
|   |   System.Diagnostics.DiagnosticSource.dll
|   |   System.IO.dll
|   |   System.IO.Hashing.dll
|   |   System.IO.Pipelines.dll
|   |   System.Memory.Data.dll
|   |   System.Memory.dll
|   |   System.Net.Http.dll
|   |   System.Net.Http.Formatting.dll
|   |   System.Numerics.Vectors.dll
|   |   System.Runtime.CompilerServices.Unsafe.dll
|   |   System.Runtime.dll
|   |   System.Security.AccessControl.dll
|   |   System.Security.Cryptography.Algorithms.dll
|   |   System.Security.Cryptography.Encoding.dll
|   |   System.Security.Cryptography.Primitives.dll
|   |   System.Security.Cryptography.X509Certificates.dll
|   |   System.Security.Permissions.dll
|   |   System.Security.Principal.Windows.dll
|   |   System.Text.Encodings.Web.dll
|   |   System.Text.Json.dll
|   |   System.Text.RegularExpressions.dll
|   |   System.Threading.Tasks.Extensions.dll
|   |   System.ValueTuple.dll
|   |   System.Web.Helpers.dll
|   |   System.Web.Http.dll
|   |   System.Web.Http.WebHost.dll
|   |   System.Web.Mvc.dll
|   |   System.Web.Optimization.dll
|   |   System.Web.Razor.dll
|   |   System.Web.WebPages.Deployment.dll
|   |   System.Web.WebPages.dll
|   |   System.Web.WebPages.Razor.dll
|   |   Unity.Abstractions.dll
|   |   Unity.AspNet.WebApi.dll
|   |   Unity.Container.dll
|   |   Unity.Mvc5.dll
|   |   WebActivatorEx.dll
|   |   WebGrease.dll
|   |   
|   \---roslyn
+---ILLink
|       ILLink.Descriptors.LibraryBuild.xml
|       
+---NLog
|       Logger.cs
|       
+---obj
|   +---Debug
|   |   |   .NETFramework,Version=v4.8.AssemblyAttributes.cs
|   |   |   Build with Advantage.csproj.AssemblyReference.cache
|   |   |   Build with Advantage.csproj.CoreCompileInputs.cache
|   |   |   Build with Advantage.csproj.FileListAbsolute.txt
|   |   |   DesignTimeResolveAssemblyReferences.cache
|   |   |   DesignTimeResolveAssemblyReferencesInput.cache
|   |   |   
|   |   \---TempPE
|   \---Release
|           .NETFramework,Version=v4.8.AssemblyAttributes.cs
|           Build with Advantage.csproj.AssemblyReference.cache
|           
+---packages
|   +---Antlr.3.4.1.9004
|   |   |   .signature.p7s
|   |   |   Antlr.3.4.1.9004.nupkg
|   |   |   
|   |   \---lib
|   |           Antlr3.Runtime.dll
|   |           Antlr3.Runtime.pdb
|   |           
|   +---Antlr.3.5.0.2
|   |   |   .signature.p7s
|   |   |   Antlr.3.5.0.2.nupkg
|   |   |   
|   |   \---lib
|   |           Antlr3.Runtime.dll
|   |           Antlr3.Runtime.pdb
|   |           
|   +---Antlr3.Runtime.3.5.1
|   |   |   .signature.p7s
|   |   |   Antlr3.Runtime.3.5.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net20
|   |       |       Antlr3.Runtime.dll
|   |       |       Antlr3.Runtime.xml
|   |       |       
|   |       +---net40-client
|   |       |       Antlr3.Runtime.dll
|   |       |       Antlr3.Runtime.xml
|   |       |       
|   |       +---netstandard1.1
|   |       |       Antlr3.Runtime.dll
|   |       |       Antlr3.Runtime.xml
|   |       |       
|   |       \---portable-net4+sl5+netcore45+wpa81+wp8+MonoAndroid1+MonoTouch1
|   |               Antlr3.Runtime.dll
|   |               Antlr3.Runtime.xml
|   |               
|   +---Autofac.8.2.0
|   |   |   .signature.p7s
|   |   |   Autofac.8.2.0.nupkg
|   |   |   icon.png
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net6.0
|   |       |       Autofac.dll
|   |       |       Autofac.xml
|   |       |       
|   |       +---net7.0
|   |       |       Autofac.dll
|   |       |       Autofac.xml
|   |       |       
|   |       +---net8.0
|   |       |       Autofac.dll
|   |       |       Autofac.xml
|   |       |       
|   |       +---netstandard2.0
|   |       |       Autofac.dll
|   |       |       Autofac.xml
|   |       |       
|   |       \---netstandard2.1
|   |               Autofac.dll
|   |               Autofac.xml
|   |               
|   +---Azure.AI.OpenAI.1.0.0-beta.7
|   |   |   .signature.p7s
|   |   |   Azure.AI.OpenAI.1.0.0-beta.7.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.AI.OpenAI.dll
|   |               Azure.AI.OpenAI.xml
|   |               
|   +---Azure.AI.OpenAI.1.0.0-beta.9
|   |   |   .signature.p7s
|   |   |   Azure.AI.OpenAI.1.0.0-beta.9.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.AI.OpenAI.dll
|   |               Azure.AI.OpenAI.xml
|   |               
|   +---Azure.AI.Translation.Document.2.0.0
|   |   |   .signature.p7s
|   |   |   Azure.AI.Translation.Document.2.0.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.AI.Translation.Document.dll
|   |               Azure.AI.Translation.Document.xml
|   |               
|   +---Azure.AI.Translation.Text.1.0.0
|   |   |   .signature.p7s
|   |   |   Azure.AI.Translation.Text.1.0.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.AI.Translation.Text.dll
|   |               Azure.AI.Translation.Text.xml
|   |               
|   +---Azure.Core.1.39.0
|   |   |   .signature.p7s
|   |   |   Azure.Core.1.39.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net461
|   |       |       Azure.Core.dll
|   |       |       Azure.Core.xml
|   |       |       
|   |       +---net472
|   |       |       Azure.Core.dll
|   |       |       Azure.Core.xml
|   |       |       
|   |       +---net6.0
|   |       |       Azure.Core.dll
|   |       |       Azure.Core.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Azure.Core.dll
|   |               Azure.Core.xml
|   |               
|   +---Azure.Core.1.44.1
|   |   |   .signature.p7s
|   |   |   Azure.Core.1.44.1.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net461
|   |       |       Azure.Core.dll
|   |       |       Azure.Core.xml
|   |       |       
|   |       +---net472
|   |       |       Azure.Core.dll
|   |       |       Azure.Core.xml
|   |       |       
|   |       +---net6.0
|   |       |       Azure.Core.dll
|   |       |       Azure.Core.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Azure.Core.dll
|   |               Azure.Core.xml
|   |               
|   +---Azure.Data.Tables.12.9.0
|   |   |   .signature.p7s
|   |   |   Azure.Data.Tables.12.9.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.Data.Tables.dll
|   |               Azure.Data.Tables.xml
|   |               
|   +---Azure.Identity.1.13.1
|   |   |   .signature.p7s
|   |   |   Azure.Identity.1.13.1.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.Identity.dll
|   |               Azure.Identity.xml
|   |               
|   +---Azure.ResourceManager.1.13.0
|   |   |   .signature.p7s
|   |   |   Azure.ResourceManager.1.13.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.ResourceManager.dll
|   |               Azure.ResourceManager.xml
|   |               
|   +---Azure.ResourceManager.Compute.1.7.0
|   |   |   .signature.p7s
|   |   |   Azure.ResourceManager.Compute.1.7.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net8.0
|   |       |       Azure.ResourceManager.Compute.dll
|   |       |       Azure.ResourceManager.Compute.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Azure.ResourceManager.Compute.dll
|   |               Azure.ResourceManager.Compute.xml
|   |               
|   +---Azure.ResourceManager.KeyVault.1.3.0
|   |   |   .signature.p7s
|   |   |   Azure.ResourceManager.KeyVault.1.3.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.ResourceManager.KeyVault.dll
|   |               Azure.ResourceManager.KeyVault.xml
|   |               
|   +---Azure.ResourceManager.TrafficManager.1.1.2
|   |   |   .signature.p7s
|   |   |   Azure.ResourceManager.TrafficManager.1.1.2.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.ResourceManager.TrafficManager.dll
|   |               Azure.ResourceManager.TrafficManager.xml
|   |               
|   +---Azure.Security.KeyVault.Certificates.4.7.0
|   |   |   .signature.p7s
|   |   |   Azure.Security.KeyVault.Certificates.4.7.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Azure.Security.KeyVault.Certificates.dll
|   |               Azure.Security.KeyVault.Certificates.xml
|   |               
|   +---Azure.Storage.Blobs.12.20.0
|   |   |   .signature.p7s
|   |   |   Azure.Storage.Blobs.12.20.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net6.0
|   |       |       Azure.Storage.Blobs.dll
|   |       |       Azure.Storage.Blobs.xml
|   |       |       
|   |       +---netstandard2.0
|   |       |       Azure.Storage.Blobs.dll
|   |       |       Azure.Storage.Blobs.xml
|   |       |       
|   |       \---netstandard2.1
|   |               Azure.Storage.Blobs.dll
|   |               Azure.Storage.Blobs.xml
|   |               
|   +---Azure.Storage.Blobs.12.23.0
|   |   |   .signature.p7s
|   |   |   Azure.Storage.Blobs.12.23.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net6.0
|   |       |       Azure.Storage.Blobs.dll
|   |       |       Azure.Storage.Blobs.xml
|   |       |       
|   |       +---netstandard2.0
|   |       |       Azure.Storage.Blobs.dll
|   |       |       Azure.Storage.Blobs.xml
|   |       |       
|   |       \---netstandard2.1
|   |               Azure.Storage.Blobs.dll
|   |               Azure.Storage.Blobs.xml
|   |               
|   +---Azure.Storage.Common.12.19.0
|   |   |   .signature.p7s
|   |   |   Azure.Storage.Common.12.19.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net6.0
|   |       |       Azure.Storage.Common.dll
|   |       |       Azure.Storage.Common.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Azure.Storage.Common.dll
|   |               Azure.Storage.Common.xml
|   |               
|   +---Azure.Storage.Common.12.22.0
|   |   |   .signature.p7s
|   |   |   Azure.Storage.Common.12.22.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net6.0
|   |       |       Azure.Storage.Common.dll
|   |       |       Azure.Storage.Common.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Azure.Storage.Common.dll
|   |               Azure.Storage.Common.xml
|   |               
|   +---Azure.Storage.Files.Shares.12.18.0
|   |   |   .signature.p7s
|   |   |   Azure.Storage.Files.Shares.12.18.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net6.0
|   |       |       Azure.Storage.Files.Shares.dll
|   |       |       Azure.Storage.Files.Shares.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Azure.Storage.Files.Shares.dll
|   |               Azure.Storage.Files.Shares.xml
|   |               
|   +---Azure.Storage.Queues.12.18.0
|   |   |   .signature.p7s
|   |   |   Azure.Storage.Queues.12.18.0.nupkg
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net6.0
|   |       |       Azure.Storage.Queues.dll
|   |       |       Azure.Storage.Queues.xml
|   |       |       
|   |       +---netstandard2.0
|   |       |       Azure.Storage.Queues.dll
|   |       |       Azure.Storage.Queues.xml
|   |       |       
|   |       \---netstandard2.1
|   |               Azure.Storage.Queues.dll
|   |               Azure.Storage.Queues.xml
|   |               
|   +---bootstrap.5.2.3
|   |   |   .signature.p7s
|   |   |   bootstrap.5.2.3.nupkg
|   |   |   bootstrap.png
|   |   |   
|   |   +---content
|   |   |   +---Content
|   |   |   |       bootstrap-grid.css
|   |   |   |       bootstrap-grid.css.map
|   |   |   |       bootstrap-grid.min.css
|   |   |   |       bootstrap-grid.min.css.map
|   |   |   |       bootstrap-grid.rtl.css
|   |   |   |       bootstrap-grid.rtl.css.map
|   |   |   |       bootstrap-grid.rtl.min.css
|   |   |   |       bootstrap-grid.rtl.min.css.map
|   |   |   |       bootstrap-reboot.css
|   |   |   |       bootstrap-reboot.css.map
|   |   |   |       bootstrap-reboot.min.css
|   |   |   |       bootstrap-reboot.min.css.map
|   |   |   |       bootstrap-reboot.rtl.css
|   |   |   |       bootstrap-reboot.rtl.css.map
|   |   |   |       bootstrap-reboot.rtl.min.css
|   |   |   |       bootstrap-reboot.rtl.min.css.map
|   |   |   |       bootstrap-utilities.css
|   |   |   |       bootstrap-utilities.css.map
|   |   |   |       bootstrap-utilities.min.css
|   |   |   |       bootstrap-utilities.min.css.map
|   |   |   |       bootstrap-utilities.rtl.css
|   |   |   |       bootstrap-utilities.rtl.css.map
|   |   |   |       bootstrap-utilities.rtl.min.css
|   |   |   |       bootstrap-utilities.rtl.min.css.map
|   |   |   |       bootstrap.css
|   |   |   |       bootstrap.css.map
|   |   |   |       bootstrap.min.css
|   |   |   |       bootstrap.min.css.map
|   |   |   |       bootstrap.rtl.css
|   |   |   |       bootstrap.rtl.css.map
|   |   |   |       bootstrap.rtl.min.css
|   |   |   |       bootstrap.rtl.min.css.map
|   |   |   |       
|   |   |   \---Scripts
|   |   |           bootstrap.bundle.js
|   |   |           bootstrap.bundle.js.map
|   |   |           bootstrap.bundle.min.js
|   |   |           bootstrap.bundle.min.js.map
|   |   |           bootstrap.esm.js
|   |   |           bootstrap.esm.js.map
|   |   |           bootstrap.esm.min.js
|   |   |           bootstrap.esm.min.js.map
|   |   |           bootstrap.js
|   |   |           bootstrap.js.map
|   |   |           bootstrap.min.js
|   |   |           bootstrap.min.js.map
|   |   |           
|   |   \---contentFiles
|   |       \---any
|   |           \---any
|   |               \---wwwroot
|   |                   +---css
|   |                   |       bootstrap-grid.css
|   |                   |       bootstrap-grid.css.map
|   |                   |       bootstrap-grid.min.css
|   |                   |       bootstrap-grid.min.css.map
|   |                   |       bootstrap-grid.rtl.css
|   |                   |       bootstrap-grid.rtl.css.map
|   |                   |       bootstrap-grid.rtl.min.css
|   |                   |       bootstrap-grid.rtl.min.css.map
|   |                   |       bootstrap-reboot.css
|   |                   |       bootstrap-reboot.css.map
|   |                   |       bootstrap-reboot.min.css
|   |                   |       bootstrap-reboot.min.css.map
|   |                   |       bootstrap-reboot.rtl.css
|   |                   |       bootstrap-reboot.rtl.css.map
|   |                   |       bootstrap-reboot.rtl.min.css
|   |                   |       bootstrap-reboot.rtl.min.css.map
|   |                   |       bootstrap-utilities.css
|   |                   |       bootstrap-utilities.css.map
|   |                   |       bootstrap-utilities.min.css
|   |                   |       bootstrap-utilities.min.css.map
|   |                   |       bootstrap-utilities.rtl.css
|   |                   |       bootstrap-utilities.rtl.css.map
|   |                   |       bootstrap-utilities.rtl.min.css
|   |                   |       bootstrap-utilities.rtl.min.css.map
|   |                   |       bootstrap.css
|   |                   |       bootstrap.css.map
|   |                   |       bootstrap.min.css
|   |                   |       bootstrap.min.css.map
|   |                   |       bootstrap.rtl.css
|   |                   |       bootstrap.rtl.css.map
|   |                   |       bootstrap.rtl.min.css
|   |                   |       bootstrap.rtl.min.css.map
|   |                   |       
|   |                   \---js
|   |                           bootstrap.bundle.js
|   |                           bootstrap.bundle.js.map
|   |                           bootstrap.bundle.min.js
|   |                           bootstrap.bundle.min.js.map
|   |                           bootstrap.esm.js
|   |                           bootstrap.esm.js.map
|   |                           bootstrap.esm.min.js
|   |                           bootstrap.esm.min.js.map
|   |                           bootstrap.js
|   |                           bootstrap.js.map
|   |                           bootstrap.min.js
|   |                           bootstrap.min.js.map
|   |                           
|   +---jQuery.3.7.0
|   |   |   .signature.p7s
|   |   |   jQuery.3.7.0.nupkg
|   |   |   
|   |   +---Content
|   |   |   \---Scripts
|   |   |           jquery-3.7.0-vsdoc.js
|   |   |           jquery-3.7.0.js
|   |   |           jquery-3.7.0.min.js
|   |   |           jquery-3.7.0.min.map
|   |   |           jquery-3.7.0.slim.js
|   |   |           jquery-3.7.0.slim.min.js
|   |   |           jquery-3.7.0.slim.min.map
|   |   |           
|   |   \---Tools
|   |           common.ps1
|   |           install.ps1
|   |           jquery-3.7.0.intellisense.js
|   |           uninstall.ps1
|   |           
|   +---jQuery.Validation.1.19.5
|   |   |   .signature.p7s
|   |   |   jQuery.Validation.1.19.5.nupkg
|   |   |   
|   |   \---Content
|   |       \---Scripts
|   |               jquery.validate-vsdoc.js
|   |               jquery.validate.js
|   |               jquery.validate.min.js
|   |               
|   +---Microsoft.AspNet.Mvc.5.2.7
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.Mvc.5.2.7.nupkg
|   |   |   
|   |   +---Content
|   |   |       Web.config.install.xdt
|   |   |       Web.config.uninstall.xdt
|   |   |       
|   |   \---lib
|   |       \---net45
|   |               System.Web.Mvc.dll
|   |               System.Web.Mvc.xml
|   |               
|   +---Microsoft.AspNet.Mvc.5.2.9
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.Mvc.5.2.9.nupkg
|   |   |   NET.icon.png
|   |   |   NET_Library_EULA_ENU.txt
|   |   |   
|   |   +---Content
|   |   |       Web.config.install.xdt
|   |   |       Web.config.uninstall.xdt
|   |   |       
|   |   \---lib
|   |       \---net45
|   |               System.Web.Mvc.dll
|   |               System.Web.Mvc.xml
|   |               
|   +---Microsoft.AspNet.Mvc.5.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.Mvc.5.3.0.nupkg
|   |   |   NET.icon.png
|   |   |   NET_Library_EULA_ENU.txt
|   |   |   
|   |   +---Content
|   |   |       Web.config.install.xdt
|   |   |       Web.config.uninstall.xdt
|   |   |       
|   |   \---lib
|   |       \---net45
|   |               System.Web.Mvc.dll
|   |               System.Web.Mvc.xml
|   |               
|   +---Microsoft.AspNet.Razor.3.2.9
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.Razor.3.2.9.nupkg
|   |   |   NET.icon.png
|   |   |   NET_Library_EULA_ENU.txt
|   |   |   
|   |   \---lib
|   |       \---net45
|   |               System.Web.Razor.dll
|   |               System.Web.Razor.xml
|   |               
|   +---Microsoft.AspNet.Razor.3.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.Razor.3.3.0.nupkg
|   |   |   NET.icon.png
|   |   |   NET_Library_EULA_ENU.txt
|   |   |   
|   |   \---lib
|   |       \---net45
|   |               System.Web.Razor.dll
|   |               System.Web.Razor.xml
|   |               
|   +---Microsoft.AspNet.Web.Optimization.1.1.3
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.Web.Optimization.1.1.3.nupkg
|   |   |   
|   |   \---lib
|   |       \---net40
|   |               System.Web.Optimization.dll
|   |               system.web.optimization.xml
|   |               
|   +---Microsoft.AspNet.WebApi.5.3.0
|   |       .signature.p7s
|   |       Microsoft.AspNet.WebApi.5.3.0.nupkg
|   |       NET.icon.png
|   |       NET_Library_EULA_ENU.txt
|   |       
|   +---Microsoft.AspNet.WebApi.Client.6.0.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.WebApi.Client.6.0.0.nupkg
|   |   |   NET.icon.png
|   |   |   NET_Library_EULA_ENU.txt
|   |   |   
|   |   \---lib
|   |       +---net45
|   |       |       System.Net.Http.Formatting.dll
|   |       |       System.Net.Http.Formatting.xml
|   |       |       
|   |       +---netstandard1.3
|   |       |       System.Net.Http.Formatting.dll
|   |       |       System.Net.Http.Formatting.xml
|   |       |       
|   |       \---netstandard2.0
|   |               System.Net.Http.Formatting.dll
|   |               System.Net.Http.Formatting.xml
|   |               
|   +---Microsoft.AspNet.WebApi.Core.5.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.WebApi.Core.5.3.0.nupkg
|   |   |   NET.icon.png
|   |   |   NET_Library_EULA_ENU.txt
|   |   |   
|   |   +---Content
|   |   |       web.config.transform
|   |   |       
|   |   \---lib
|   |       \---net45
|   |               System.Web.Http.dll
|   |               System.Web.Http.xml
|   |               
|   +---Microsoft.AspNet.WebApi.WebHost.5.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.WebApi.WebHost.5.3.0.nupkg
|   |   |   NET.icon.png
|   |   |   NET_Library_EULA_ENU.txt
|   |   |   
|   |   \---lib
|   |       \---net45
|   |               System.Web.Http.WebHost.dll
|   |               System.Web.Http.WebHost.xml
|   |               
|   +---Microsoft.AspNet.WebPages.3.2.9
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.WebPages.3.2.9.nupkg
|   |   |   NET.icon.png
|   |   |   NET_Library_EULA_ENU.txt
|   |   |   
|   |   +---Content
|   |   |       Web.config.install.xdt
|   |   |       Web.config.uninstall.xdt
|   |   |       
|   |   \---lib
|   |       \---net45
|   |               System.Web.Helpers.dll
|   |               System.Web.Helpers.xml
|   |               System.Web.WebPages.Deployment.dll
|   |               System.Web.WebPages.Deployment.xml
|   |               System.Web.WebPages.dll
|   |               System.Web.WebPages.Razor.dll
|   |               System.Web.WebPages.Razor.xml
|   |               System.Web.WebPages.xml
|   |               
|   +---Microsoft.AspNet.WebPages.3.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNet.WebPages.3.3.0.nupkg
|   |   |   NET.icon.png
|   |   |   NET_Library_EULA_ENU.txt
|   |   |   
|   |   +---Content
|   |   |       Web.config.install.xdt
|   |   |       Web.config.uninstall.xdt
|   |   |       
|   |   \---lib
|   |       \---net45
|   |               System.Web.Helpers.dll
|   |               System.Web.Helpers.xml
|   |               System.Web.WebPages.Deployment.dll
|   |               System.Web.WebPages.Deployment.xml
|   |               System.Web.WebPages.dll
|   |               System.Web.WebPages.Razor.dll
|   |               System.Web.WebPages.Razor.xml
|   |               System.Web.WebPages.xml
|   |               
|   +---Microsoft.AspNetCore.Antiforgery.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Antiforgery.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Antiforgery.dll
|   |               Microsoft.AspNetCore.Antiforgery.xml
|   |               
|   +---Microsoft.AspNetCore.Authentication.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Authentication.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Authentication.Abstractions.dll
|   |               Microsoft.AspNetCore.Authentication.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.Authentication.Core.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Authentication.Core.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Authentication.Core.dll
|   |               Microsoft.AspNetCore.Authentication.Core.xml
|   |               
|   +---Microsoft.AspNetCore.Authorization.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Authorization.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Authorization.dll
|   |               Microsoft.AspNetCore.Authorization.xml
|   |               
|   +---Microsoft.AspNetCore.Authorization.Policy.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Authorization.Policy.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Authorization.Policy.dll
|   |               Microsoft.AspNetCore.Authorization.Policy.xml
|   |               
|   +---Microsoft.AspNetCore.Cryptography.Internal.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Cryptography.Internal.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Cryptography.Internal.dll
|   |               Microsoft.AspNetCore.Cryptography.Internal.xml
|   |               
|   +---Microsoft.AspNetCore.DataProtection.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.DataProtection.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.DataProtection.dll
|   |               Microsoft.AspNetCore.DataProtection.xml
|   |               
|   +---Microsoft.AspNetCore.DataProtection.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.DataProtection.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.DataProtection.Abstractions.dll
|   |               Microsoft.AspNetCore.DataProtection.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.Diagnostics.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Diagnostics.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Diagnostics.Abstractions.dll
|   |               Microsoft.AspNetCore.Diagnostics.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.Hosting.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Hosting.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Hosting.Abstractions.dll
|   |               Microsoft.AspNetCore.Hosting.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.Hosting.Server.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Hosting.Server.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Hosting.Server.Abstractions.dll
|   |               Microsoft.AspNetCore.Hosting.Server.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.Html.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Html.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Html.Abstractions.dll
|   |               Microsoft.AspNetCore.Html.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.Http.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Http.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Http.dll
|   |               Microsoft.AspNetCore.Http.xml
|   |               
|   +---Microsoft.AspNetCore.Http.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Http.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Http.Abstractions.dll
|   |               Microsoft.AspNetCore.Http.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.Http.Extensions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Http.Extensions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Http.Extensions.dll
|   |               Microsoft.AspNetCore.Http.Extensions.xml
|   |               
|   +---Microsoft.AspNetCore.Http.Features.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Http.Features.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Http.Features.dll
|   |               Microsoft.AspNetCore.Http.Features.xml
|   |               
|   +---Microsoft.AspNetCore.JsonPatch.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.JsonPatch.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.JsonPatch.dll
|   |               Microsoft.AspNetCore.JsonPatch.xml
|   |               
|   +---Microsoft.AspNetCore.Mvc.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Mvc.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Mvc.Abstractions.dll
|   |               Microsoft.AspNetCore.Mvc.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.Mvc.Core.2.2.5
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Mvc.Core.2.2.5.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Mvc.Core.dll
|   |               Microsoft.AspNetCore.Mvc.Core.xml
|   |               
|   +---Microsoft.AspNetCore.Mvc.Core.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Mvc.Core.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Mvc.Core.dll
|   |               Microsoft.AspNetCore.Mvc.Core.xml
|   |               
|   +---Microsoft.AspNetCore.Mvc.DataAnnotations.2.2.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Mvc.DataAnnotations.2.2.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Mvc.DataAnnotations.dll
|   |               Microsoft.AspNetCore.Mvc.DataAnnotations.xml
|   |               
|   +---Microsoft.AspNetCore.Mvc.DataAnnotations.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Mvc.DataAnnotations.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Mvc.DataAnnotations.dll
|   |               Microsoft.AspNetCore.Mvc.DataAnnotations.xml
|   |               
|   +---Microsoft.AspNetCore.Mvc.Formatters.Json.2.2.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Mvc.Formatters.Json.2.2.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Mvc.Formatters.Json.dll
|   |               Microsoft.AspNetCore.Mvc.Formatters.Json.xml
|   |               
|   +---Microsoft.AspNetCore.Mvc.Formatters.Json.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Mvc.Formatters.Json.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Mvc.Formatters.Json.dll
|   |               Microsoft.AspNetCore.Mvc.Formatters.Json.xml
|   |               
|   +---Microsoft.AspNetCore.Mvc.ViewFeatures.2.2.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Mvc.ViewFeatures.2.2.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Mvc.ViewFeatures.dll
|   |               Microsoft.AspNetCore.Mvc.ViewFeatures.xml
|   |               
|   +---Microsoft.AspNetCore.Mvc.ViewFeatures.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Mvc.ViewFeatures.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Mvc.ViewFeatures.dll
|   |               Microsoft.AspNetCore.Mvc.ViewFeatures.xml
|   |               
|   +---Microsoft.AspNetCore.ResponseCaching.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.ResponseCaching.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.ResponseCaching.Abstractions.dll
|   |               Microsoft.AspNetCore.ResponseCaching.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.Routing.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Routing.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Routing.dll
|   |               Microsoft.AspNetCore.Routing.xml
|   |               
|   +---Microsoft.AspNetCore.Routing.Abstractions.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.Routing.Abstractions.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.Routing.Abstractions.dll
|   |               Microsoft.AspNetCore.Routing.Abstractions.xml
|   |               
|   +---Microsoft.AspNetCore.WebUtilities.2.3.0
|   |   |   .signature.p7s
|   |   |   Microsoft.AspNetCore.WebUtilities.2.3.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.AspNetCore.WebUtilities.dll
|   |               Microsoft.AspNetCore.WebUtilities.xml
|   |               
|   +---Microsoft.Azure.Cosmos.3.46.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE
|   |   |   Microsoft.Azure.Cosmos.3.46.1.nupkg
|   |   |   ThirdPartyNotice.txt
|   |   |   
|   |   +---build
|   |   |   \---netstandard2.0
|   |   |           Microsoft.Azure.Cosmos.targets
|   |   |           
|   |   +---buildTransitive
|   |   |   \---netstandard2.0
|   |   |           Microsoft.Azure.Cosmos.targets
|   |   |           
|   |   +---lib
|   |   |   \---netstandard2.0
|   |   |           Microsoft.Azure.Cosmos.Client.dll
|   |   |           Microsoft.Azure.Cosmos.Client.xml
|   |   |           Microsoft.Azure.Cosmos.Core.dll
|   |   |           Microsoft.Azure.Cosmos.Direct.dll
|   |   |           Microsoft.Azure.Cosmos.Serialization.HybridRow.dll
|   |   |           
|   |   \---runtimes
|   |       \---win-x64
|   |           \---native
|   |                   Cosmos.CRTCompat.dll
|   |                   Microsoft.Azure.Cosmos.ServiceInterop.dll
|   |                   msvcp140.dll
|   |                   vcruntime140.dll
|   |                   vcruntime140_1.dll
|   |                   
|   +---Microsoft.Azure.KeyVault.3.0.5
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.KeyVault.3.0.5.nupkg
|   |   |   pkgicon.png
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.KeyVault.dll
|   |       |       
|   |       +---net461
|   |       |       Microsoft.Azure.KeyVault.dll
|   |       |       
|   |       +---netstandard1.4
|   |       |       Microsoft.Azure.KeyVault.dll
|   |       |       
|   |       \---netstandard2.0
|   |               Microsoft.Azure.KeyVault.dll
|   |               
|   +---Microsoft.Azure.KeyVault.Core.1.0.0
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.KeyVault.Core.1.0.0.nupkg
|   |   |   
|   |   \---lib
|   |       +---net40
|   |       |       Microsoft.Azure.KeyVault.Core.dll
|   |       |       Microsoft.Azure.KeyVault.Core.xml
|   |       |       
|   |       \---portable-net45+wp8+wpa81+win
|   |               Microsoft.Azure.KeyVault.Core.dll
|   |               Microsoft.Azure.KeyVault.Core.xml
|   |               
|   +---Microsoft.Azure.KeyVault.WebKey.3.0.5
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.KeyVault.WebKey.3.0.5.nupkg
|   |   |   pkgicon.png
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.KeyVault.WebKey.dll
|   |       |       
|   |       +---net461
|   |       |       Microsoft.Azure.KeyVault.WebKey.dll
|   |       |       
|   |       +---netstandard1.4
|   |       |       Microsoft.Azure.KeyVault.WebKey.dll
|   |       |       
|   |       \---netstandard2.0
|   |               Microsoft.Azure.KeyVault.WebKey.dll
|   |               
|   +---Microsoft.Azure.Management.AppService.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.AppService.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.AppService.Fluent.dll
|   |       |       Microsoft.Azure.Management.AppService.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.AppService.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.AppService.Fluent.dll
|   |               Microsoft.Azure.Management.AppService.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.AppService.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.BatchAI.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.BatchAI.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.BatchAI.Fluent.dll
|   |       |       Microsoft.Azure.Management.BatchAI.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.BatchAI.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.BatchAI.Fluent.dll
|   |               Microsoft.Azure.Management.BatchAI.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.BatchAI.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Cdn.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Cdn.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Cdn.Fluent.dll
|   |       |       Microsoft.Azure.Management.Cdn.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Cdn.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Cdn.Fluent.dll
|   |               Microsoft.Azure.Management.Cdn.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Cdn.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Compute.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Compute.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Compute.Fluent.dll
|   |       |       Microsoft.Azure.Management.Compute.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Compute.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Compute.Fluent.dll
|   |               Microsoft.Azure.Management.Compute.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Compute.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.ContainerInstance.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.ContainerInstance.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.ContainerInstance.Fluent.dll
|   |       |       Microsoft.Azure.Management.ContainerInstance.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.ContainerInstance.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.ContainerInstance.Fluent.dll
|   |               Microsoft.Azure.Management.ContainerInstance.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.ContainerInstance.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.ContainerRegistry.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.ContainerRegistry.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.ContainerRegistry.Fluent.dll
|   |       |       Microsoft.Azure.Management.ContainerRegistry.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.ContainerRegistry.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.ContainerRegistry.Fluent.dll
|   |               Microsoft.Azure.Management.ContainerRegistry.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.ContainerRegistry.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.ContainerService.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.ContainerService.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.ContainerService.Fluent.dll
|   |       |       Microsoft.Azure.Management.ContainerService.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.ContainerService.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.ContainerService.Fluent.dll
|   |               Microsoft.Azure.Management.ContainerService.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.ContainerService.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.CosmosDB.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.CosmosDB.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.CosmosDB.Fluent.dll
|   |       |       Microsoft.Azure.Management.CosmosDB.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.CosmosDB.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.CosmosDB.Fluent.dll
|   |               Microsoft.Azure.Management.CosmosDB.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.CosmosDB.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Dns.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Dns.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Dns.Fluent.dll
|   |       |       Microsoft.Azure.Management.Dns.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Dns.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Dns.Fluent.dll
|   |               Microsoft.Azure.Management.Dns.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Dns.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.EventHub.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.EventHub.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.EventHub.Fluent.dll
|   |       |       Microsoft.Azure.Management.EventHub.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.EventHub.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.EventHub.Fluent.dll
|   |               Microsoft.Azure.Management.EventHub.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.EventHub.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Fluent.dll
|   |       |       Microsoft.Azure.Management.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Fluent.dll
|   |               Microsoft.Azure.Management.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Graph.RBAC.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Graph.RBAC.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Graph.RBAC.Fluent.dll
|   |       |       Microsoft.Azure.Management.Graph.RBAC.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Graph.RBAC.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Graph.RBAC.Fluent.dll
|   |               Microsoft.Azure.Management.Graph.RBAC.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Graph.RBAC.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.KeyVault.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.KeyVault.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.KeyVault.Fluent.dll
|   |       |       Microsoft.Azure.Management.KeyVault.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.KeyVault.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.KeyVault.Fluent.dll
|   |               Microsoft.Azure.Management.KeyVault.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.KeyVault.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Locks.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Locks.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Locks.Fluent.dll
|   |       |       Microsoft.Azure.Management.Locks.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Locks.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Locks.Fluent.dll
|   |               Microsoft.Azure.Management.Locks.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Locks.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Monitor.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Monitor.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Monitor.Fluent.dll
|   |       |       Microsoft.Azure.Management.Monitor.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Monitor.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Monitor.Fluent.dll
|   |               Microsoft.Azure.Management.Monitor.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Monitor.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Msi.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Msi.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Msi.Fluent.dll
|   |       |       Microsoft.Azure.Management.Msi.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Msi.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Msi.Fluent.dll
|   |               Microsoft.Azure.Management.Msi.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Msi.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Network.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Network.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Network.Fluent.dll
|   |       |       Microsoft.Azure.Management.Network.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Network.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Network.Fluent.dll
|   |               Microsoft.Azure.Management.Network.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Network.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.PrivateDns.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.PrivateDns.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.PrivateDns.Fluent.dll
|   |       |       Microsoft.Azure.Management.PrivateDns.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.PrivateDns.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.PrivateDns.Fluent.dll
|   |               Microsoft.Azure.Management.PrivateDns.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.PrivateDns.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Redis.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Redis.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Redis.Fluent.dll
|   |       |       Microsoft.Azure.Management.Redis.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Redis.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Redis.Fluent.dll
|   |               Microsoft.Azure.Management.Redis.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Redis.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.ResourceManager.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.ResourceManager.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.ResourceManager.Fluent.dll
|   |       |       Microsoft.Azure.Management.ResourceManager.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.ResourceManager.Fluent.xml
|   |       |       
|   |       +---net461
|   |       |       Microsoft.Azure.Management.ResourceManager.Fluent.dll
|   |       |       Microsoft.Azure.Management.ResourceManager.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.ResourceManager.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.ResourceManager.Fluent.dll
|   |               Microsoft.Azure.Management.ResourceManager.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.ResourceManager.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Search.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Search.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Search.Fluent.dll
|   |       |       Microsoft.Azure.Management.Search.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Search.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Search.Fluent.dll
|   |               Microsoft.Azure.Management.Search.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Search.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.ServiceBus.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.ServiceBus.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.ServiceBus.Fluent.dll
|   |       |       Microsoft.Azure.Management.ServiceBus.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.ServiceBus.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.ServiceBus.Fluent.dll
|   |               Microsoft.Azure.Management.ServiceBus.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.ServiceBus.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Sql.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Sql.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Sql.Fluent.dll
|   |       |       Microsoft.Azure.Management.Sql.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Sql.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Sql.Fluent.dll
|   |               Microsoft.Azure.Management.Sql.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Sql.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.Storage.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.Storage.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.Storage.Fluent.dll
|   |       |       Microsoft.Azure.Management.Storage.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.Storage.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.Storage.Fluent.dll
|   |               Microsoft.Azure.Management.Storage.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.Storage.Fluent.xml
|   |               
|   +---Microsoft.Azure.Management.TrafficManager.Fluent.1.38.1
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Management.TrafficManager.Fluent.1.38.1.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Management.TrafficManager.Fluent.dll
|   |       |       Microsoft.Azure.Management.TrafficManager.Fluent.runtimeconfig.json
|   |       |       Microsoft.Azure.Management.TrafficManager.Fluent.xml
|   |       |       
|   |       \---netstandard1.4
|   |               Microsoft.Azure.Management.TrafficManager.Fluent.dll
|   |               Microsoft.Azure.Management.TrafficManager.Fluent.runtimeconfig.json
|   |               Microsoft.Azure.Management.TrafficManager.Fluent.xml
|   |               
|   +---Microsoft.Azure.Storage.Blob.11.2.3
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Storage.Blob.11.2.3.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Storage.Blob.dll
|   |       |       Microsoft.Azure.Storage.Blob.xml
|   |       |       
|   |       +---netstandard1.3
|   |       |       Microsoft.Azure.Storage.Blob.dll
|   |       |       Microsoft.Azure.Storage.Blob.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Microsoft.Azure.Storage.Blob.dll
|   |               Microsoft.Azure.Storage.Blob.xml
|   |               
|   +---Microsoft.Azure.Storage.Common.11.2.3
|   |   |   .signature.p7s
|   |   |   Microsoft.Azure.Storage.Common.11.2.3.nupkg
|   |   |   
|   |   \---lib
|   |       +---net452
|   |       |       Microsoft.Azure.Storage.Common.dll
|   |       |       Microsoft.Azure.Storage.Common.xml
|   |       |       
|   |       +---netstandard1.3
|   |       |       Microsoft.Azure.Storage.Common.dll
|   |       |       Microsoft.Azure.Storage.Common.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Microsoft.Azure.Storage.Common.dll
|   |               Microsoft.Azure.Storage.Common.xml
|   |               
|   +---Microsoft.Bcl.AsyncInterfaces.1.1.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Bcl.AsyncInterfaces.1.1.1.nupkg
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   version.txt
|   |   |   
|   |   +---lib
|   |   |   +---net461
|   |   |   |       Microsoft.Bcl.AsyncInterfaces.dll
|   |   |   |       Microsoft.Bcl.AsyncInterfaces.xml
|   |   |   |       
|   |   |   +---netstandard2.0
|   |   |   |       Microsoft.Bcl.AsyncInterfaces.dll
|   |   |   |       Microsoft.Bcl.AsyncInterfaces.xml
|   |   |   |       
|   |   |   \---netstandard2.1
|   |   |           Microsoft.Bcl.AsyncInterfaces.dll
|   |   |           Microsoft.Bcl.AsyncInterfaces.xml
|   |   |           
|   |   \---ref
|   |       +---net461
|   |       |       Microsoft.Bcl.AsyncInterfaces.dll
|   |       |       
|   |       +---netstandard2.0
|   |       |       Microsoft.Bcl.AsyncInterfaces.dll
|   |       |       
|   |       \---netstandard2.1
|   |               Microsoft.Bcl.AsyncInterfaces.dll
|   |               
|   +---Microsoft.Bcl.AsyncInterfaces.9.0.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Bcl.AsyncInterfaces.9.0.1.nupkg
|   |   |   PACKAGE.md
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   
|   |   +---buildTransitive
|   |   |   +---net461
|   |   |   |       Microsoft.Bcl.AsyncInterfaces.targets
|   |   |   |       
|   |   |   +---net462
|   |   |   |       _._
|   |   |   |       
|   |   |   +---net8.0
|   |   |   |       _._
|   |   |   |       
|   |   |   \---netcoreapp2.0
|   |   |           Microsoft.Bcl.AsyncInterfaces.targets
|   |   |           
|   |   \---lib
|   |       +---net462
|   |       |       Microsoft.Bcl.AsyncInterfaces.dll
|   |       |       Microsoft.Bcl.AsyncInterfaces.xml
|   |       |       
|   |       +---netstandard2.0
|   |       |       Microsoft.Bcl.AsyncInterfaces.dll
|   |       |       Microsoft.Bcl.AsyncInterfaces.xml
|   |       |       
|   |       \---netstandard2.1
|   |               Microsoft.Bcl.AsyncInterfaces.dll
|   |               Microsoft.Bcl.AsyncInterfaces.xml
|   |               
|   +---Microsoft.Bcl.HashCode.1.1.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Bcl.HashCode.1.1.1.nupkg
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   version.txt
|   |   |   
|   |   +---lib
|   |   |   +---net461
|   |   |   |       Microsoft.Bcl.HashCode.dll
|   |   |   |       Microsoft.Bcl.HashCode.xml
|   |   |   |       
|   |   |   +---netcoreapp2.1
|   |   |   |       Microsoft.Bcl.HashCode.dll
|   |   |   |       Microsoft.Bcl.HashCode.xml
|   |   |   |       
|   |   |   +---netstandard2.0
|   |   |   |       Microsoft.Bcl.HashCode.dll
|   |   |   |       Microsoft.Bcl.HashCode.xml
|   |   |   |       
|   |   |   \---netstandard2.1
|   |   |           Microsoft.Bcl.HashCode.dll
|   |   |           Microsoft.Bcl.HashCode.xml
|   |   |           
|   |   \---ref
|   |       +---net461
|   |       |       Microsoft.Bcl.HashCode.dll
|   |       |       
|   |       +---netcoreapp2.1
|   |       |       Microsoft.Bcl.HashCode.dll
|   |       |       
|   |       +---netstandard2.0
|   |       |       Microsoft.Bcl.HashCode.dll
|   |       |       
|   |       \---netstandard2.1
|   |               Microsoft.Bcl.HashCode.dll
|   |               
|   +---Microsoft.Bcl.TimeProvider.8.0.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Bcl.TimeProvider.8.0.1.nupkg
|   |   |   PACKAGE.md
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   
|   |   +---buildTransitive
|   |   |   +---net461
|   |   |   |       Microsoft.Bcl.TimeProvider.targets
|   |   |   |       
|   |   |   +---net462
|   |   |   |       _._
|   |   |   |       
|   |   |   +---net6.0
|   |   |   |       _._
|   |   |   |       
|   |   |   \---netcoreapp2.0
|   |   |           Microsoft.Bcl.TimeProvider.targets
|   |   |           
|   |   \---lib
|   |       +---net462
|   |       |       Microsoft.Bcl.TimeProvider.dll
|   |       |       Microsoft.Bcl.TimeProvider.xml
|   |       |       
|   |       +---net8.0
|   |       |       Microsoft.Bcl.TimeProvider.dll
|   |       |       Microsoft.Bcl.TimeProvider.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Microsoft.Bcl.TimeProvider.dll
|   |               Microsoft.Bcl.TimeProvider.xml
|   |               
|   +---Microsoft.CodeDom.Providers.DotNetCompilerPlatform.2.0.1
|   |   |   .signature.p7s
|   |   |   Microsoft.CodeDom.Providers.DotNetCompilerPlatform.2.0.1.nupkg
|   |   |   
|   |   +---build
|   |   |   +---net45
|   |   |   |       Microsoft.CodeDom.Providers.DotNetCompilerPlatform.Extensions.props
|   |   |   |       Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props
|   |   |   |       
|   |   |   \---net46
|   |   |           Microsoft.CodeDom.Providers.DotNetCompilerPlatform.Extensions.props
|   |   |           Microsoft.CodeDom.Providers.DotNetCompilerPlatform.props
|   |   |           
|   |   +---content
|   |   |   +---net45
|   |   |   |       app.config.install.xdt
|   |   |   |       app.config.uninstall.xdt
|   |   |   |       web.config.install.xdt
|   |   |   |       web.config.uninstall.xdt
|   |   |   |       
|   |   |   \---net46
|   |   |           app.config.install.xdt
|   |   |           app.config.uninstall.xdt
|   |   |           web.config.install.xdt
|   |   |           web.config.uninstall.xdt
|   |   |           
|   |   +---lib
|   |   |   \---net45
|   |   |           Microsoft.CodeDom.Providers.DotNetCompilerPlatform.dll
|   |   |           Microsoft.CodeDom.Providers.DotNetCompilerPlatform.xml
|   |   |           
|   |   \---tools
|   |       +---net45
|   |       |       install.ps1
|   |       |       uninstall.ps1
|   |       |       
|   |       +---Roslyn45
|   |       |       csc.exe
|   |       |       csc.exe.config
|   |       |       csc.rsp
|   |       |       csi.exe
|   |       |       csi.rsp
|   |       |       Microsoft.Build.Tasks.CodeAnalysis.dll
|   |       |       Microsoft.CodeAnalysis.CSharp.dll
|   |       |       Microsoft.CodeAnalysis.CSharp.Scripting.dll
|   |       |       Microsoft.CodeAnalysis.dll
|   |       |       Microsoft.CodeAnalysis.Scripting.dll
|   |       |       Microsoft.CodeAnalysis.VisualBasic.dll
|   |       |       Microsoft.CSharp.Core.targets
|   |       |       Microsoft.DiaSymReader.Native.amd64.dll
|   |       |       Microsoft.DiaSymReader.Native.x86.dll
|   |       |       Microsoft.VisualBasic.Core.targets
|   |       |       System.AppContext.dll
|   |       |       System.Collections.Immutable.dll
|   |       |       System.Diagnostics.StackTrace.dll
|   |       |       System.IO.FileSystem.dll
|   |       |       System.IO.FileSystem.Primitives.dll
|   |       |       System.Reflection.Metadata.dll
|   |       |       vbc.exe
|   |       |       vbc.exe.config
|   |       |       vbc.rsp
|   |       |       VBCSCompiler.exe
|   |       |       VBCSCompiler.exe.config
|   |       |       
|   |       \---RoslynLatest
|   |               csc.exe
|   |               csc.exe.config
|   |               csc.rsp
|   |               csi.exe
|   |               csi.exe.config
|   |               csi.rsp
|   |               Microsoft.Build.Tasks.CodeAnalysis.dll
|   |               Microsoft.CodeAnalysis.CSharp.dll
|   |               Microsoft.CodeAnalysis.CSharp.Scripting.dll
|   |               Microsoft.CodeAnalysis.dll
|   |               Microsoft.CodeAnalysis.Scripting.dll
|   |               Microsoft.CodeAnalysis.VisualBasic.dll
|   |               Microsoft.CSharp.Core.targets
|   |               Microsoft.DiaSymReader.Native.amd64.dll
|   |               Microsoft.DiaSymReader.Native.x86.dll
|   |               Microsoft.Managed.Core.targets
|   |               Microsoft.VisualBasic.Core.targets
|   |               Microsoft.Win32.Primitives.dll
|   |               System.AppContext.dll
|   |               System.Collections.Immutable.dll
|   |               System.Console.dll
|   |               System.Diagnostics.DiagnosticSource.dll
|   |               System.Diagnostics.FileVersionInfo.dll
|   |               System.Diagnostics.StackTrace.dll
|   |               System.Globalization.Calendars.dll
|   |               System.IO.Compression.dll
|   |               System.IO.Compression.ZipFile.dll
|   |               System.IO.FileSystem.dll
|   |               System.IO.FileSystem.Primitives.dll
|   |               System.Net.Http.dll
|   |               System.Net.Sockets.dll
|   |               System.Reflection.Metadata.dll
|   |               System.Runtime.InteropServices.RuntimeInformation.dll
|   |               System.Security.Cryptography.Algorithms.dll
|   |               System.Security.Cryptography.Encoding.dll
|   |               System.Security.Cryptography.Primitives.dll
|   |               System.Security.Cryptography.X509Certificates.dll
|   |               System.Text.Encoding.CodePages.dll
|   |               System.Threading.Tasks.Extensions.dll
|   |               System.ValueTuple.dll
|   |               System.Xml.ReaderWriter.dll
|   |               System.Xml.XmlDocument.dll
|   |               System.Xml.XPath.dll
|   |               System.Xml.XPath.XDocument.dll
|   |               vbc.exe
|   |               vbc.exe.config
|   |               vbc.rsp
|   |               VBCSCompiler.exe
|   |               VBCSCompiler.exe.config
|   |               
|   +---Microsoft.Configuration.ConfigurationBuilders.Base.3.0.0
|   |   |   .signature.p7s
|   |   |   Microsoft.Configuration.ConfigurationBuilders.Base.3.0.0.nupkg
|   |   |   
|   |   +---content
|   |   |   \---Net471
|   |   |           app.config.install.xdt
|   |   |           app.config.uninstall.xdt
|   |   |           web.config.install.xdt
|   |   |           web.config.uninstall.xdt
|   |   |           
|   |   +---docs
|   |   |       Readme.md
|   |   |       
|   |   +---images
|   |   |       dotnet-icon.png
|   |   |       
|   |   \---lib
|   |       \---Net471
|   |               Microsoft.Configuration.ConfigurationBuilders.Base.dll
|   |               Microsoft.Configuration.ConfigurationBuilders.Base.xml
|   |               
|   +---Microsoft.Configuration.ConfigurationBuilders.UserSecrets.3.0.0
|   |   |   .signature.p7s
|   |   |   Microsoft.Configuration.ConfigurationBuilders.UserSecrets.3.0.0.nupkg
|   |   |   
|   |   +---content
|   |   |   \---Net471
|   |   |           app.config.install.xdt
|   |   |           app.config.uninstall.xdt
|   |   |           web.config.install.xdt
|   |   |           web.config.uninstall.xdt
|   |   |           
|   |   +---docs
|   |   |       Readme.md
|   |   |       
|   |   +---images
|   |   |       dotnet-icon.png
|   |   |       
|   |   +---lib
|   |   |   \---Net471
|   |   |           Microsoft.Configuration.ConfigurationBuilders.UserSecrets.dll
|   |   |           Microsoft.Configuration.ConfigurationBuilders.UserSecrets.xml
|   |   |           
|   |   \---tools
|   |       \---Net471
|   |               Install.ps1
|   |               KeyValueConfigBuildersCommon.ps1
|   |               Uninstall.ps1
|   |               
|   +---Microsoft.CSharp.4.5.0
|   |   |   .signature.p7s
|   |   |   LICENSE.TXT
|   |   |   Microsoft.CSharp.4.5.0.nupkg
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   version.txt
|   |   |   
|   |   +---lib
|   |   |   +---MonoAndroid10
|   |   |   |       _._
|   |   |   |       
|   |   |   +---MonoTouch10
|   |   |   |       _._
|   |   |   |       
|   |   |   +---net45
|   |   |   |       _._
|   |   |   |       
|   |   |   +---netcore50
|   |   |   |       Microsoft.CSharp.dll
|   |   |   |       
|   |   |   +---netcoreapp2.0
|   |   |   |       _._
|   |   |   |       
|   |   |   +---netstandard1.3
|   |   |   |       Microsoft.CSharp.dll
|   |   |   |       
|   |   |   +---netstandard2.0
|   |   |   |       Microsoft.CSharp.dll
|   |   |   |       
|   |   |   +---portable-net45+win8+wp8+wpa81
|   |   |   |       _._
|   |   |   |       
|   |   |   +---uap10.0.16299
|   |   |   |       _._
|   |   |   |       
|   |   |   +---win8
|   |   |   |       _._
|   |   |   |       
|   |   |   +---wp80
|   |   |   |       _._
|   |   |   |       
|   |   |   +---wpa81
|   |   |   |       _._
|   |   |   |       
|   |   |   +---xamarinios10
|   |   |   |       _._
|   |   |   |       
|   |   |   +---xamarinmac20
|   |   |   |       _._
|   |   |   |       
|   |   |   +---xamarintvos10
|   |   |   |       _._
|   |   |   |       
|   |   |   \---xamarinwatchos10
|   |   |           _._
|   |   |           
|   |   \---ref
|   |       +---MonoAndroid10
|   |       |       _._
|   |       |       
|   |       +---MonoTouch10
|   |       |       _._
|   |       |       
|   |       +---net45
|   |       |       _._
|   |       |       
|   |       +---netcore50
|   |       |   |   Microsoft.CSharp.dll
|   |       |   |   Microsoft.CSharp.xml
|   |       |   |   
|   |       |   +---de
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---es
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---fr
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---it
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---ja
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---ko
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---ru
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---zh-hans
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   \---zh-hant
|   |       |           Microsoft.CSharp.xml
|   |       |           
|   |       +---netcoreapp2.0
|   |       |       _._
|   |       |       
|   |       +---netstandard1.0
|   |       |   |   Microsoft.CSharp.dll
|   |       |   |   Microsoft.CSharp.xml
|   |       |   |   
|   |       |   +---de
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---es
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---fr
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---it
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---ja
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---ko
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---ru
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   +---zh-hans
|   |       |   |       Microsoft.CSharp.xml
|   |       |   |       
|   |       |   \---zh-hant
|   |       |           Microsoft.CSharp.xml
|   |       |           
|   |       +---netstandard2.0
|   |       |       Microsoft.CSharp.dll
|   |       |       Microsoft.CSharp.xml
|   |       |       
|   |       +---portable-net45+win8+wp8+wpa81
|   |       |       _._
|   |       |       
|   |       +---uap10.0.16299
|   |       |       _._
|   |       |       
|   |       +---win8
|   |       |       _._
|   |       |       
|   |       +---wp80
|   |       |       _._
|   |       |       
|   |       +---wpa81
|   |       |       _._
|   |       |       
|   |       +---xamarinios10
|   |       |       _._
|   |       |       
|   |       +---xamarinmac20
|   |       |       _._
|   |       |       
|   |       +---xamarintvos10
|   |       |       _._
|   |       |       
|   |       \---xamarinwatchos10
|   |               _._
|   |               
|   +---Microsoft.DotNet.PlatformAbstractions.2.1.0
|   |   |   .signature.p7s
|   |   |   LICENSE.TXT
|   |   |   Microsoft.DotNet.PlatformAbstractions.2.1.0.nupkg
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   
|   |   \---lib
|   |       +---net45
|   |       |       Microsoft.DotNet.PlatformAbstractions.dll
|   |       |       
|   |       \---netstandard1.3
|   |               Microsoft.DotNet.PlatformAbstractions.dll
|   |               
|   +---Microsoft.Extensions.Azure.1.7.3
|   |   |   .signature.p7s
|   |   |   azureicon.png
|   |   |   CHANGELOG.md
|   |   |   Microsoft.Extensions.Azure.1.7.3.nupkg
|   |   |   README.md
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.Extensions.Azure.dll
|   |               Microsoft.Extensions.Azure.xml
|   |               
|   +---Microsoft.Extensions.Configuration.9.0.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Extensions.Configuration.9.0.1.nupkg
|   |   |   PACKAGE.md
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   
|   |   +---buildTransitive
|   |   |   +---net461
|   |   |   |       Microsoft.Extensions.Configuration.targets
|   |   |   |       
|   |   |   +---net462
|   |   |   |       _._
|   |   |   |       
|   |   |   +---net8.0
|   |   |   |       _._
|   |   |   |       
|   |   |   \---netcoreapp2.0
|   |   |           Microsoft.Extensions.Configuration.targets
|   |   |           
|   |   \---lib
|   |       +---net462
|   |       |       Microsoft.Extensions.Configuration.dll
|   |       |       Microsoft.Extensions.Configuration.xml
|   |       |       
|   |       +---net8.0
|   |       |       Microsoft.Extensions.Configuration.dll
|   |       |       Microsoft.Extensions.Configuration.xml
|   |       |       
|   |       +---net9.0
|   |       |       Microsoft.Extensions.Configuration.dll
|   |       |       Microsoft.Extensions.Configuration.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Microsoft.Extensions.Configuration.dll
|   |               Microsoft.Extensions.Configuration.xml
|   |               
|   +---Microsoft.Extensions.Configuration.Abstractions.9.0.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Extensions.Configuration.Abstractions.9.0.1.nupkg
|   |   |   PACKAGE.md
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   
|   |   +---buildTransitive
|   |   |   +---net461
|   |   |   |       Microsoft.Extensions.Configuration.Abstractions.targets
|   |   |   |       
|   |   |   +---net462
|   |   |   |       _._
|   |   |   |       
|   |   |   +---net8.0
|   |   |   |       _._
|   |   |   |       
|   |   |   \---netcoreapp2.0
|   |   |           Microsoft.Extensions.Configuration.Abstractions.targets
|   |   |           
|   |   \---lib
|   |       +---net462
|   |       |       Microsoft.Extensions.Configuration.Abstractions.dll
|   |       |       Microsoft.Extensions.Configuration.Abstractions.xml
|   |       |       
|   |       +---net8.0
|   |       |       Microsoft.Extensions.Configuration.Abstractions.dll
|   |       |       Microsoft.Extensions.Configuration.Abstractions.xml
|   |       |       
|   |       +---net9.0
|   |       |       Microsoft.Extensions.Configuration.Abstractions.dll
|   |       |       Microsoft.Extensions.Configuration.Abstractions.xml
|   |       |       
|   |       \---netstandard2.0
|   |               Microsoft.Extensions.Configuration.Abstractions.dll
|   |               Microsoft.Extensions.Configuration.Abstractions.xml
|   |               
|   +---Microsoft.Extensions.Configuration.Binder.2.1.0
|   |   |   .signature.p7s
|   |   |   Microsoft.Extensions.Configuration.Binder.2.1.0.nupkg
|   |   |   
|   |   \---lib
|   |       \---netstandard2.0
|   |               Microsoft.Extensions.Configuration.Binder.dll
|   |               Microsoft.Extensions.Configuration.Binder.xml
|   |               
|   +---Microsoft.Extensions.DependencyInjection.9.0.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Extensions.DependencyInjection.9.0.1.nupkg
|   |   |   PACKAGE.md
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   
|   |   +---buildTransitive
|   |   |   +---net461
|   |   |   |       Microsoft.Extensions.DependencyInjection.targets
|   |   |   |       
|   |   |   +---net462
|   |   |   |       _._
|   |   |   |       
|   |   |   +---net8.0
|   |   |   |       _._
|   |   |   |       
|   |   |   \---netcoreapp2.0
|   |   |           Microsoft.Extensions.DependencyInjection.targets
|   |   |           
|   |   \---lib
|   |       +---net462
|   |       |       Microsoft.Extensions.DependencyInjection.dll
|   |       |       Microsoft.Extensions.DependencyInjection.xml
|   |       |       
|   |       +---net8.0
|   |       |       Microsoft.Extensions.DependencyInjection.dll
|   |       |       Microsoft.Extensions.DependencyInjection.xml
|   |       |       
|   |       +---net9.0
|   |       |       Microsoft.Extensions.DependencyInjection.dll
|   |       |       Microsoft.Extensions.DependencyInjection.xml
|   |       |       
|   |       +---netstandard2.0
|   |       |       Microsoft.Extensions.DependencyInjection.dll
|   |       |       Microsoft.Extensions.DependencyInjection.xml
|   |       |       
|   |       \---netstandard2.1
|   |               Microsoft.Extensions.DependencyInjection.dll
|   |               Microsoft.Extensions.DependencyInjection.xml
|   |               
|   +---Microsoft.Extensions.DependencyInjection.Abstractions.9.0.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Extensions.DependencyInjection.Abstractions.9.0.1.nupkg
|   |   |   PACKAGE.md
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   
|   |   +---buildTransitive
|   |   |   +---net461
|   |   |   |       Microsoft.Extensions.DependencyInjection.Abstractions.targets
|   |   |   |       
|   |   |   +---net462
|   |   |   |       _._
|   |   |   |       
|   |   |   +---net8.0
|   |   |   |       _._
|   |   |   |       
|   |   |   \---netcoreapp2.0
|   |   |           Microsoft.Extensions.DependencyInjection.Abstractions.targets
|   |   |           
|   |   \---lib
|   |       +---net462
|   |       |       Microsoft.Extensions.DependencyInjection.Abstractions.dll
|   |       |       Microsoft.Extensions.DependencyInjection.Abstractions.xml
|   |       |       
|   |       +---net8.0
|   |       |       Microsoft.Extensions.DependencyInjection.Abstractions.dll
|   |       |       Microsoft.Extensions.DependencyInjection.Abstractions.xml
|   |       |       
|   |       +---net9.0
|   |       |       Microsoft.Extensions.DependencyInjection.Abstractions.dll
|   |       |       Microsoft.Extensions.DependencyInjection.Abstractions.xml
|   |       |       
|   |       +---netstandard2.0
|   |       |       Microsoft.Extensions.DependencyInjection.Abstractions.dll
|   |       |       Microsoft.Extensions.DependencyInjection.Abstractions.xml
|   |       |       
|   |       \---netstandard2.1
|   |               Microsoft.Extensions.DependencyInjection.Abstractions.dll
|   |               Microsoft.Extensions.DependencyInjection.Abstractions.xml
|   |               
|   +---Microsoft.Extensions.DependencyModel.2.1.0
|   |   |   .signature.p7s
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Extensions.DependencyModel.2.1.0.nupkg
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   
|   |   \---lib
|   |       +---net451
|   |       |       Microsoft.Extensions.DependencyModel.dll
|   |       |       
|   |       +---netstandard1.3
|   |       |       Microsoft.Extensions.DependencyModel.dll
|   |       |       
|   |       \---netstandard1.6
|   |               Microsoft.Extensions.DependencyModel.dll
|   |               
|   +---Microsoft.Extensions.Diagnostics.Abstractions.8.0.1
|   |   |   .signature.p7s
|   |   |   Icon.png
|   |   |   LICENSE.TXT
|   |   |   Microsoft.Extensions.Diagnostics.Abstractions.8.0.1.nupkg
|   |   |   THIRD-PARTY-NOTICES.TXT
|   |   |   useSharedDesignerContext.txt
|   |   |   
|   |   +---buildTransitive
|   |   |   +---net461
|   |   |   |       Microsoft.Extensions.Diagnostics.Abstractions.targets
|   |   |   |       
|   |   |   +---net462
|   |   |   |       _._
|   |   |   |       
|   |   |   +---net6.0
|   |   |   |       _._
|   |   |   |       
|   |   |   \---netcoreapp2.0
|   |   |           Microsoft.Extensions.Diagnostics.Abstractions.targets
|   |   |           
|   |   \---lib
|   |       +---net462
|   |       |       Microsoft.Extensions.Diagnostics.Abstractions.dll
|   |       |       Microsoft.Extensions.Diagnostics.Abstractions.xml
|   |       |       
|   |       +---net6.0
|   |       |       Microsoft.Extensions.Diagnostics.Abstractions.dll
|   |       |       Microsoft.Extensions.Diagnostics.Abstractions.xml
|   |       |       
|   |       +---net7.0
|   |       |       Microsoft.Extensions.Diagnostics.Abstractions.dll
|   |       |       Microsoft.Extensions.Diagnostics.Abstractions.xml
|   |       |       
|   |       +---net8.0
|   |       |       Microsoft.Extensi
