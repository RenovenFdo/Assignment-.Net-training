import re,os
pattern1='[\w+]+@[\w]+\.[\w]{1,3}'
print("Valid emails:")
log=filter(lambda el:el.endswith("log"),os.listdir())
for file in log:
     with open(file, 'r') as fo:
        data = fo.read()
        matches = re.findall(pattern1, data)
        for match in matches:
            print(match)


