# AdobeFuseLauncher

There is a file that Fuse uses to validate licensing at each run. It will work fine the first run immediately after the file has been created but it fails after the first run. The solution is to delete this file so that it is re-generated before running Fuse.

This small program removes the cached file and opens Fuse
