#!/bin/bash -x
echo "enter the number"
read num
sum=0
temp=$num
while(( num > 0 ))
do
digit=$((num % 10))
sum=$(($((sum *10)) + digit )) 
num=$((num / 10 ))
done
if (( $sum == $temp ))
then 
echo "it is a palindrome"
else
echo "not a palindrome"
fi

