#!/bin/bash
 
declare -astart

declare -a end

echo "enter the stating time:"

#read n

for ((i=0;i < 3;i++))

do

read n

start[i]=$((start[i] + n ))

do

echo "start time is :" $start[0] "HH" $start[1] "MM" $start[2] "SS"

echo "enter the ending time"

#read n1

for(( i=0;i< 3;i++))

do

read n1


end[i]=$((end[i]+ n ))

do

echo " stop time is :" $end[0] "HH" $end[1] "MM" $end[2] "SS"

#echo "start time is :" $start[0] "HH" $start[1] "MM" $start[2] "SS"

#echo " stop time is :" $end[0] "HH" $end[1] "MM" $end[2] "SS"

str=""
n3=$(echo 3600 60 |awk '{print $start[0] * $1  +  $start[1] *$2 +$start[2]}')

n4=$(echo 3600 60 |awk '{print $end[0] * $1  +  $end[1] *$2 +$end[2]}')

t=$((n3 - n4))

hours=$((t / 3600))

min =$(echo 3600 60 $hour $t |awk '{print (((($4 - $3)) * (($1 / $2))))}')
sec = $(echo 3600 60 $hour $min $t |awk '{print  (( $5 - (($3 - $1)) - (($4 * $2))))}') 

echo "the elaspsed time"$hours "HH" $min "mm" $sec "SS"
