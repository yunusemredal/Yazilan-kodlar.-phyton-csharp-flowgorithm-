print(""""****************
Kullanıcı Girişi:
****************
""")

sys_kullanıcı_adı = "yed"
sys_parola = "12345"

kullanıcı_adı = input("Kullanıcı adı :")
parola = input("parola")

if (kullanıcı_adı == sys_kullanıcı_adı and parola != sys_parola):
    print("parola hatalı")
elif(kullanıcı_adı != sys_kullanıcı_adı and parola == sys_parola):
    print("Kullanıcı adı hatalı")
elif(kullanıcı_adı != sys_kullanıcı_adı and parola != sys_parola):
    print("Kullanıcı adı ve Parola hatalı")
else:
    print("Sisteme başarıyla giriş yapıldı")

