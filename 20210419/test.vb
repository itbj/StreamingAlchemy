API.Function("OverlayInputAllOff")
Sleep(300)
Input.Find("NewsHD.xaml").Text("Headline") = "Hello World!"
API.Function("OverlayInput3In",Input:=5)
Sleep(3000)
API.Function("OverlayInput3Out",Input:=5)
Sleep(500)
API.Function("CubeZoom",,1000)
