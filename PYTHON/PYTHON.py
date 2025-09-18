def ejer1():

 precio_producto = float(input("Ingrese el precio del producto: "))
 print("\n[1]. ESTUDIANTE\n[2]. EMPLEADO\n[3]. CLIENTE FRECUENTE")
 codigo_descuento= int(input("Ingrese el codigo de descuento (1-3): "))
 descuento = 0
 aumento = 0
 precio_final = 0

 if precio_producto > 0 and (codigo_descuento==1 or codigo_descuento==2 or codigo_descuento==3):

    if codigo_descuento == 1:
        descuento = precio_producto * 0.10
    elif codigo_descuento == 2:
        descuento = precio_producto * 0.15
    elif codigo_descuento == 3:
        descuento = precio_producto * 0.20
    else:
        print("Codigo de descuento invalido.")
       

 if precio_producto > 500:
            aumento = precio_producto * 0.05

 precio_final = precio_producto - descuento + aumento

 print (f"\nDescuento aplicado: ${descuento:.2f} soles")
 print (f"Aumento aplicado: ${aumento:.2f} soles")
 print (f"Precio final del producto: ${precio_final:.2f} soles")

def ejer2():
    import math
    nota = int(input("Ingrese su nota (0-20): "))

    if 0<=nota<=20:
        print("TU NOTA ESTA DENTRO DEL RANGO")
    else:
            print("TU NOTA ESTA FUERA DEL RANGO")

    match nota:
        case n if 0 <= n <= 10:
            print("DESAPROBADO")
        case n if 11 <= n <= 13:
            print("REGULAR")
        case n if 14 <= n <= 17:
                print("BUENO")
        case n if 18 <= n <= 20:
                print("EXCELENTE")
        case _:
                print("NOTA INVALIDA")

    if nota >= 14 and nota % 2 == 0:
       print("Buen desempeno con nota par")
     
    if nota < 11 or nota % 2 != 0:
       print("Necesita reforzar") 

    raiz = math.sqrt(nota)
    potencia = math.pow(nota, 1/3) 

    print(f"Raiz cuadrada: {raiz}")
    print(f"Raiz cubica: {potencia}")




ejer1()
