 #!/bin/bash
a=0
b=1
c=0
read n
for((i=0;i<n;i++))
do
c=$((a+b))
a=$b
b=$c
 echo $a
done
