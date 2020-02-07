#!/bin/bash -x
echo "enter the number"
read num
i=2

for i in num
do
	if [ $(( num % 2 )) == 0 ]
then
	echo "2"
	num=$(( num / 2 ))

fi
j=3
for  j in   num
do
	if [ $(( num % j )) == 0 ]
then
	echo "3"
	num=$(( num / 3 ))
fi
 j=$((j + 2 ))
done
i=$((i + 2 ))
done
if [ $num > 2 ]
then
echo "${num}"
fi
