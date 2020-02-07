#!/bin/bash -x

power_two=1
 echo "enter a number"
read num 
for ((i=0;i<=$num;i++))
do
	echo "${i}" " ${power_two}"
	power_two=$((2* power_two))
	echo "${power_two}"
done
