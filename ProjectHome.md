This application is a plug-in for use with Weather Station Data Logger (WSDL https://sourceforge.net/projects/wmrx00/ ) to control X10 devices using data from the weather station.

This plug-in receives weather data from the WSDL server to automate the control of systems using X10 control devices.  In its current form it controls a barn fan based on the apparent temperature or measured temperature outside.  It also controls a basic HVAC system (AC compressor, heat, fans, mixing, fresh air fan, etc).  In addition, it will enable/disable a sprinkler system based on rain.  This project is somewhat specialized for my needs so I view it more as a template to build what you want from it.  For instance, you may want full control over the sprinklers, not just enable/disable based on rain.  You can easily add sprinkler circuits with a module for each.  Then add timers for them.

This project was written in C# using Visual Studio Express 2010 which is free from Microsoft.  It uses .Net 4.0.

Parts of this project use source files from the Weather Station Data Logger project.

See the [manual](http://code.google.com/p/wsdl-x10/wiki/Manual) for installation and operation.

Please use the issues list (tab above) to post all bug reports or enhancement requests.

![http://home.mchsi.com/~jroal/pic/jimsx10.png](http://home.mchsi.com/~jroal/pic/jimsx10.png)