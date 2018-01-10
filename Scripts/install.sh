#! /bin/sh

echo 'Downloading from https://netstorage.unity3d.com/unity/a9f86dcd79df/MacEditorInstaller/Unity-2017.3.0f3.pkg: '
curl -o Unity.pkg https://netstorage.unity3d.com/unity/a9f86dcd79df/MacEditorInstaller/Unity-2017.3.0f3.pkg

echo 'Installing Unity.pkg'
sudo installer -dumplog -package Unity.pkg -target /
