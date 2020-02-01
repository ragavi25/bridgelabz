#!/bin/bash
echo "enter the first string"
read str
echo "enter the second string"
read str1
n=${#str}
n1=${#str1}
if((n==n1))
then
echo " it is a anagram"
else
echo "not a anagram"
fi
