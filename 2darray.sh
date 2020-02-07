#!/bin/bash -x
declare -a Amatrix
echo " enter row value"
read m
echo "enter colum value"
read n
echo "A matrix"
for ((i=0;i<m;i++))
do
for ((j=0;j<n;j++))
do
	read Amatrix[$i,$j]
done
done
 declare -a Bmatrix 
echo "B matrix" 
for ((i=0;i<m;i++))
do
for ((j=0;j<n;j++))
do
	read Bmatrix[$i,$j]
done
done
#for ((i=0;i<m;i++))
#do
#for ((j=0;j<n;j++))

#do
#	echo "${Amatrix[$i,$j]}"
#done
#done

#for ((i=0;i<m;i++))
#do
#for ((j=0;j<n;j++))
#do
#	echo "${Bmatrix[$i,$j]}"
#done
#done
echo "matrix result"
declare -a C
for ((i=0;i<m;i++))
do
for ((j=0;j<n;j++))
do

	C[$i,$j]=$((Amatrix[i,j] + Bmatrix[i,j]))
done
done
for ((i=0;i<m;i++))
do
for((j=0;j<n;j++))
do
echo " ${C[$i,$j]}"
done
done

