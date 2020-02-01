#!/bin/bash -x
echo "gambler's stating bankroll(amount)"

read stake

echo "gambler's desired bankroll(goal amount)"

read goal
echo "number of trials to perform"

read trials

bets=0

wins=0

for ((t=0;t < trials;t++ ))

do
	cash=$stake

while (( cash > 0 && cash < goal))

do

 bets=$((bets + 1))

if ((cash < 5))

then

 cash=$((cash + 1))

else

cash =$((cash - 1))

fi

done

if (($cash == $goal))

then
 
wins=$((wins + 1))

fi

done

echo $wins "wins of" $trials

echo "precent of game won="$(($((100  * wins)) / trials))

echo "avg bets=" $((bets / trials))
