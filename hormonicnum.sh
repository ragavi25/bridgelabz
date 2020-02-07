#!/bin/bash 
 hormonic=1
echo "enter nth number"
read num
for (( i=1;i<=$num;i++))
do
		echo "$hormonic "+" 1/$i " 

	a=$(echo "$i" "$a" |awk '{print $2 + (1/$1)}')
done
	
	echo "${a}"
