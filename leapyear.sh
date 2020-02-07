#!/bin/bash
echo "enter the year"
read year

if (( $(( $year % 400 )) == 0  || $(( $year % 4 )) == 0 ))
 then
	echo "${year} is a leapyear"
elif [ $(( $year % 100 )) -ne 0 ]
 then
	echo "${year} not a leapyear"
else 
	echo "${year} is a leapyer"

fi
