#!/bin/bash
# github.com/omerayyildiz :)
projectCurrentPath="/c/Users/CASPER/Desktop/busra/turksat/turksatProject/"
cd $projectCurrentPath # direkt cd'ye verilmeyip değişkene atanarak yol verildi. windows sorun yaratıyor. 


yellow=`tput setaf 3`
blue=`tput setaf 4`          
red=`tput setaf 1`
cyan=`tput setaf 6`                              
magenta=`tput setaf 5`
reset=`tput sgr0`
line="${yellow}--------------------------------------${reset}"


echo -e "a.Yedekten Geri Yükleme\nb.Yedek Alma"
read -p "${yellow}Hangi işlemi seçmek istiyorsun Büşra?(a or b):${reset}" secim
 echo $line
 echo "İşlem Sürdürülüyor...(İşlem İptali İçin 2x CTRL+C)"  #anında iptal edebilmek için delay atılmıştır.
 sleep 7
clear


if [ $secim == 'a' ]
then
   echo -e "İlgili projede git log yazarak hashi öğrenebilirsin!\n$line"
   read -p "${cyan}Hash Kodunu Gir:${reset}" commitHash
   echo $line
   echo "İşlem Sürdürülüyor...(İşlem İptali İçin CTRL+C)"  #anında iptal edebilmek için delay atılmıştır.
   sleep 7
   clear
     git checkout $commitHash -- .
     git add .
     tarih=$(date)
     git commit -m "Yedek geri yüklendi.($tarih)"
     git push -u origin master
  #yedekten sonra commit atılacağı için dallanma yapmıyor.
     sleep 5
     clear
     echo "İşlem Tamamlandı! (Commit başarı ile kopyalandı!)"
       sleep 2
       clear
       exit
else
  echo "${cyan}Turksat Proje Güncelleme Paneline Hoşgeldin!${reset}"
  git add .
  echo "${yellow}Bugün ne değişiklik yaptın Büşra?:${reset}"
  read commitMsg
  echo $line
  git commit -m "$commitMsg"

  git push -u origin master
  clear

  echo $line
  echo "${magenta}Her şey tamamlandı!${reset}"
  echo $line
  sleep 10
fi



