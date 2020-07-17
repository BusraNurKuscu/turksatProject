#!/bin/bash
echo "Yolu Ayarlıyorum Büşra..."
sleep 2
# bu kod parçası update.sh'ın yolunu bulabilmesi için yazılmıştır.
# path start.sh'a yani şuanki dosyaya ikinci sırada yazılıyor çünkü ilk seferde yazıldığı zaman dosya çalıştığı için bash hafızaya alırken zorlanıyor.
sed -i "s|/c/Users/CASPER/Desktop/busra/turksat/turksatProject/|$(cd .. && pwd)/|g" update.sh
sed -i "s|/c/Users/CASPER/Desktop/busra/turksat/turksatProject/|$(cd .. && pwd)/|g" start.sh
bash update.sh