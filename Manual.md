  1. User Manual

# Introduction #

This is the user guide for the WSDL X10 control plug-in


# Installation #
The software was written in Microsoft Visual Studio Express C# with ASP.Net 4.0.

## Basic Requirements ##
This X10 control system requires the following components:
  * Weather Station Data Logger version 4 or higher.  You can download that from Source Forge: https://sourceforge.net/projects/wmrx00/
  * The X10 Active Home Pro software development kit.  That is available here: http://kbase.x10.com/wiki/Activehome_Pro_SDK
  * An X10 system including the CM15a or similar control host.
  * ASP.Net 4.0 (this should automatically download and install when you run the setup file)


# Operation #

The current early release is very crude and not necessarily intuitive.  Here are a few key notes for operation:
  * WSDL must be started is server mode.  It may take a minute or more to receive data and send to the clients.
  * In order to address an X10 module just enter the modules address in the text box next to the control.  For instance, the image below shows 3 modules configured.  B1 is controlling the sprinklers.  H1 is controlling the HVAC mix fan.  B2 is controlling the barn cooling fan.  If the box is blank, or the address is invalid the program will simply ignore the commands.
  * The check boxes next to each of the temperature rows is to indicate that a module is an indoor module.  This is used for the mix fan control, and to calculate apparent temp since there is generally no wind inside.
  * The check boxes next to the controls indicate the current state.  You can check them to activate the control manually but the program will just switch it back the next time a data sample is received or 30s passes.  This is handy for testing though.
  * Once you get it all set up the way you want, click the save settings button.  The settings will automatically load on the next start-up.  You can manually reload the saved settings with the reload setting button.
  * All the units except temperature are currently hard coded to US.  I plan to fix this later.
  * You can use either apparent temperatures or actual temperatures for control.  One of the big benefits of this control is the ability to control based on apparent temperatures. For more info on apparent temperatures follow this link: http://www.bom.gov.au/info/thermal_stress/
  * The auto desired humidity is used with the humidifier control.  There is a guideline on indoor humidity based on outside temperature.  You can auto control the humidifier if you check the auto box to the right of it.  This will decrease the humidity as the outside temperature decreases.  It will not raise it back though.  The units of desired humidity are in percent relative humidity.
  * The max indoor dew point is used to prevent the fresh air fan from pumping excessively humid air into the house.  If the outdoor dew point exceeds this setting, the fresh air fan is inhibited from turning ON.
  * A log file called `HomeControlLog.csv` is in the same directory as the program.  This gets updated with every X10 command so you can see the history of what happened when.  This file can be exported or deleted using menu items in the `File` menu.
  * Select either Fahrenheit or Celsius temperature units in the `options` menu.

In the example below, 3 X10 modules are used (as described above).  Sensor 0 is the internal sensor on the WMR100 base unit which is on the main floor of the house.  Sensor 2 is in the basement of the house.  These are checked to be included in the inside temperature balancing control (engaging the mix fan if the temp split is too high).

The sprinkler control is only used to enable or disable the sprinklers if the rain exceeds the threshold.

The barn cooling fan is configured to engage when the apparent temp exceeds 82F.
![http://home.mchsi.com/~jroal/pic/jimsx10.png](http://home.mchsi.com/~jroal/pic/jimsx10.png)

Minimum and maximum temperature values are captured as well.  These can be reset or viewed in the `View` menu.
![http://home.mchsi.com/~jroal/pic/min-max.png](http://home.mchsi.com/~jroal/pic/min-max.png)