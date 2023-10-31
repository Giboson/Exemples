# code_pyscript.net_1 aplet

```py
  
         <py-script>
    
            print('Hello, world!')
            name = 15
            print(name + 5)
            print([x for x in range(name)])
    
        </py-script>
  
```

## code_PyCharm_Server.net_2 servlet

```py

# This is a sample Python script.
# install Flask console >>  pip install flask     
from flask import Flask # opbect



app = Flask(__name__)

@app.route('/') # GET Default
def main():
    return '<h1>HELLO, WORLD!</h1>'

@app.route('/info') # GET Default1
def info():
    return '<h1>Text! MS MILLIERY</h1>'

@app.route('/summa/<x>/<y>') # GET Default2 sum
def summa(x, y):
    return f'<h1>{x} + {y} = {int(x) + int(y)}</h1>'


if __name__ == '__main__':

    app.run()

```
