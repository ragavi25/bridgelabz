#!/bin/bash -x

random()
{

num=$1

return $(($RANDOM%$num))
}

echo enter coupon num 

read count

echo how many digit

read digit

str="1234567890abcdfghjklmbnwertyuiopqcdf"

len=${#str}

while (( $count > 0 ))

do

s=$digit

coupon=""

  while (( $s > 0 ))
 
 do
  
random $len
  
ran=$?

  
#this is the main logic 
  
var=${str:$ran:1}
 
 coupon=$coupon$var


  s=$(($s-1))

  done

echo $coupon

count=$(($count-1))

done


