#!/bin/bash
echo "Enter the temperature value"
read t
echo "enter the Wind speed value"
read v

calc=$(echo 35.74 0.6215 $t $v 0.4275 0.16 |awk '{print "%f",$1 + $2 *$3 +$5 *$3 -$1 * $4**$6}') 
echo  "Temperature ="$t
echo "Wind speed =" $v
echo "wind chill ="$calc
