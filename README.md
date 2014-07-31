SOXS
====
SOXS is a utility created for LHC. SOXS will automatically setup the LHC environment for you. It will create the cross-compiler and give you the LHC toolchain - it also installs the required packages.

How to get SOXS
====
You do not need to download this repo to use SOXS. 

You simply have to download [the setup script] (https://raw.githubusercontent.com/JoshMiles/SOXS/master/OTHER/setup) (right click > _save as_).

Place the script in a new directory (perhaps `$HOME/LHC`) and then run it using
```
$ bash setup
```

> **WARNING: The setup script can take from twenty minutes to an hour to complete as it compiles and builds GCC from source code to create your i686-elf cross compiler! KEEP YOUR DEVICE PLUGGED IN AND DO NOT TURN IT OFF DURING SETUP.**

If you wish to cancel the setup, press ctrl+c.
