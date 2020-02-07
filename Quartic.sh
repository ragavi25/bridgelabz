#!/bin/bash
echo "enter a value "
read a
echo " enter b value"
read b
echo "enter c value"
read c
 delta=$(($(($((b * b)) - 4)) * $((a * c))))
 d=$(echo  $delta |awk '{print sqrt($1)'} )
if(( $delta >  0 ))
then
	root1=$(($((0 - b)) + $(( d / $((2 * a))))))
	roo2=$(($((0 - b)) - $((d / $((2 * a))))))
	echo "the first root :" $root1
	echo "the second root :"$root2
elif (( $delta == 0 ))
then
	root1=root2=$(($((-b))/$((2 * a))))
	echo "condition for real and equal roots:"$root1
else
	realpart=$(($((-b))/$((2 * a))))
	imaginarypart=$(($((-d))/$((2*a))))
	echo $realpart
	echo $imaginarypart
fi
