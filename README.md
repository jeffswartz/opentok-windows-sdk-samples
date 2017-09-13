# OpenTok Windows SDK Samples

 This repository provides sample applications for you to better understand the features of
 the [OpenTok Windows SDK](https://tokbox.com/developer/sdks/windows/). Feel free to copy
 and modify the source code herein for your own projects. Please consider sharing your
 modifications with us, especially if they might benefit other developers using the OpenTok
 Windows SDK. See the License for more information.

## Quick Start

1. Get values for your OpenTok **API key**, **session ID**, and **token**.

   You can obtain these values from your [TokBox account](#https://tokbox.com/account/#/).
   Make sure that the token isn't expired.

   For testing, you can use a session ID and token generated at your TokBox account page.
   However, the final application should obtain these values using the [OpenTok server
   SDKs](https://tokbox.com/developer/sdks/server/). For more information, see the OpenTok
   developer guides on [session creation](https://tokbox.com/developer/guides/create-session/)
   and [token creation](https://tokbox.com/developer/guides/create-token/).

2. In Visual Studio, open the .sln solution file for the sample app you are using
   (CustomVideoRenderer/CustomVideoRenderer.sln, ScreenSharing/ScreenSharing.sln,
   or SimpleMultiparty/SimpleMultiparty.sln).

3. Open the MainWindow.xaml.cs file for the app and edit the values for `API_KEY`, `SESSION_ID`,
   and `TOKEN` to match API key, session ID, and token data you obtained in step 1.

NuGet automatically installs the OpenTok SDK when you build the project.

## What's Inside

### SimpleMultiparty

This app shows how to implement a simple video call.

### SimpleMultiparty

This app shows how to implement a video call application with several clients.

### CustomVideoRenderer

This app shows how to use a custom video renderer. Most applications work fine with the default
renderer (VideoRenderer) included with the OpenTok Windows SDK. However, if you need to add
custom effects, this sample application provides an understanding of how to implement a custom
video renderer.

### ScreenSharing

This app shows how to publish a screen-sharing stream to a session. This implements a custom video
capturer to capturer to capture the screen as the video source for an OpenTok publisher.
