#!/bin/bash
echo "Yolu Ayarlıyorum Büşra..."
sleep 2

sed -i "s|/c/Users/CASPER/Desktop/busra/turksat/turksatProject/git-engineForTurksat/|$(cd .. && pwd)/|g" start.sh
sed -i "s|/c/Users/CASPER/Desktop/busra/turksat/turksatProject/git-engineForTurksat/|$(cd .. && pwd)/|g" update.sh
bash update.sh