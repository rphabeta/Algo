def calculate(s: str) -> int:
    s+='+' #additional last op
    stack = []
    
    cur_num = 0
    prev_op = '+'
    for c in s:
      if c.isdigit():
        cur_num = cur_num*10 + int(c)
        
      elif c == ' ':
        continue     
              
      else: #ops
        if prev_op == '+':
          stack.append(cur_num)

        elif prev_op == '-':
          stack.append(-cur_num)
          
        elif prev_op == '*':
          stack[-1] = stack[-1]*cur_num      

        elif prev_op == '/':
          stack[-1] = int(stack[-1]/cur_num)

        cur_num = 0
        prev_op = c
        
    return sum(stack)

calculate(s='7 - 6 / 3 + 3 * 2 + 4')
