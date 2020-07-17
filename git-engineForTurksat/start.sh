#!/bin/bash
echo "Yolu Ayarlıyorum Büşra..."
sleep 2

sed -i "s|/c/Users/CASPER/Desktop/busra/turksat/turksatProject/|$(cd .. && pwd)/|g" update.sh
sed -i "s|/c/Users/CASPER/Desktop/busra/turksat/turksatProject/|$(cd .. && pwd)/|g" start.sh
bash update.sh