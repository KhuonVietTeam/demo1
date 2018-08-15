using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    Player player;
    Bullet bullet;
    Fish fish;
    BulletSeller eventShoot; //ban dan
    FishBuyer eventCatch; //trung ca
    CoinBuyer eventImport; //nap Coin
    CoinSeller eventExport; //xã coin

    //khoi tao nguoi choi player 1 co 100 vang va dang dung sung 5
    private void Awake()
    {
        bullet = new Bullet(15);
        player = new Player("player", 0, 5);
        fish = new Fish("CaLaHan", 25);
        eventShoot = new BulletSeller();
        eventCatch = new FishBuyer();
        eventImport = new CoinBuyer();
        eventExport = new CoinSeller();


    }
    private void Start()
    {
        player.Info();
        Debug.Log("Mới dô game: TIỀN: " + player._wallet._value);
        for (int i = 0; i < 20; i++) { eventImport.BuyCoin(player); }
        Debug.Log("Nạp 20 thẻ: TIỀN: " + player._wallet._value);
        Debug.Log("Chọn đạn: VALUE: " + bullet._value);
        eventShoot.SellBullet(player, bullet);
        Debug.Log("Bắn 1 viên đạn: TIỀN: " + player._wallet._value);
        eventCatch.BuyFish(player, fish);
        Debug.Log("Trúng 1 con cá +25: TIỀN: " + player._wallet._value);
        eventExport.SellCoin(player);
        Debug.Log("Xã 1 coin: TIỀN: " + player._wallet._value);
        eventExport.SellAllCoins(player);
        Debug.Log("Xã ALL coin: TIỀN: " + player._wallet._value);




    }
    public Wallet()
    {
        _value = 0;
    }
    public Wallet(int initialAmount)
    {
        _value = initialAmount;
    }

    public int _value { get; private set; }

    public void AddMoney(int amount)
    {
        _value += amount;
    }

    public void SubMoney(int amount)
    {
        _value -= amount;
    }
    public void Info()
    {
        Debug.Log("Amount: " + _value);

    }
}
public class Bullet
{
    public Bullet()
    {
        _value = 5;
    }
    public Bullet(int initialBulletType)
    {
        _value = initialBulletType;
    }
    public int _value { get; private set; }
    public void AddValue(int amount)
    {
        _value += amount;
    }
    public void SubValue(int amount)
    {
        _value -= amount;
    }

}
public class Player
{
    //ham dung
    public Player()
    {
        _name = "Clone";
        _wallet = new Wallet(0);
        _bullet = 0;
    }
    public Player(string name, int wallet, int bullet)
    {
        _name = name;
        _wallet = new Wallet(wallet);
        _bullet = bullet;
    }

    public string _name { get; private set; }
    public Wallet _wallet;
    public int _bullet;

    public int PayAmount(int amountToPay)
    {
        if (_wallet._value >= amountToPay)
        {
            _wallet.SubMoney(amountToPay);
            return amountToPay;
        }
        return 0;
    }
    public void GetAmount(int amountToGet)
    {
        _wallet.AddMoney(amountToGet);

    }
    public void Info()
    {
        Debug.Log("Name: " + _name);
    }
}
public class Fish
{
    public Fish()
    {
        _name = "fish(clone)";
        _value = 0;

    }
    public Fish(string name, int value)
    {
        _name = name;
        _value = value;
    }
    public string _name;
    public int _value;
}
// đạn bắn ra 
public class BulletSeller
{
    public void SellBullet(Player player, Bullet bullet) //
    {

        var payment = bullet._value;

        var amountPaid = player.PayAmount(payment);

        if (amountPaid != payment)
        {
            // het tien
            // Khong ban duoc dan tuong ung
        }
    }
}
//Xã thẻ
public class CoinSeller
{
    public void SellCoin(Player player)
    {
        var payment = 5;
        var amountPaid = player.PayAmount(payment);
        if (amountPaid != payment)
        {
            // het tien
            // Khong xa duoc the
        }

    }
    public void SellAllCoins(Player player)
    {
        var payment = player._wallet._value;
        var amountPaid = player.PayAmount(payment);
        if (amountPaid != payment)
        {
            // het tien
            // Khong xa duoc the
        }

    }
}
//trúng cá
public class FishBuyer
{
    public void BuyFish(Player player, Fish fish)
    {
        var payment = fish._value;
        //var amountGot
        player.GetAmount(payment);
    }
}

//Nạp thẻ
public class CoinBuyer
{
    public void BuyCoin(Player player)
    {
        //mệnh giá coin mặc định là 5
        var payment = 5;
        //var amountGot
        player.GetAmount(payment);
    }
}

