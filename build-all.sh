# PayPal DataCollector
echo "PayPal DataCollector"
cd ./paypal-datacollector
sh ./build.sh
cd ../
cp -p ./paypal-datacollector/*.nupkg ./nugets/

# Braintree Core
echo "Braintree Core"
cd ./braintree-core
sh ./build.sh
cd ../
cp -p ./braintree-core/*.nupkg ./nugets/

# PayPal OneTouch
echo "PayPal OneTouch"
cd ./paypal-onetouch
sh ./build.sh
cd ../
cp -p ./paypal-onetouch/*.nupkg ./nugets/

# PayPal BrainTree
echo "BrainTree"
sh ./build.sh
cp -p ./*.nupkg ./nugets/