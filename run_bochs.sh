#!/bin/bash

sudo /sbin/losetup /dev/loop0 bootgrub
sudo bochs -f bochsrc.txt
sudo /sbin/losetup -d /dev/loop0
