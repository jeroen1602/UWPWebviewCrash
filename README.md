# Web view crash with too long URIs

When redirecting from a webpage to a non supported URI that is longer than `2084` characters the Webview will crash without the throwing any exception.  
The weird part about this is that if you redirect the webview to a URI starting with `http://` or `https://` or you send it to a malformed URI (`someting:aLotOfText`) of the same length it will be able to handle it.

## Recreating the issue

to recreate the issue start the Express.js webserver that is located in the webserver folder nad launch the UWP app located in the WebViewCrash folder. On launch the app will try and load the page `http://localhost:3000` which will redirect it to a URI after which it will crash.

## Expected behavior

The expected behavior is that you can handle the url with the `WebView.UnsupportedUriSchemeIdentified` event. But that won't even get called before the app closes.

## System information

- Windows version: Windows 10 1803
- Nuget packages:
  - Microsoft.NETCore.UniversalWindowsPlatform: 6.1.7