using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        int maxHpMonster, hpMonster, maxHpPlayer, hpPlayer;
        int hitMonster, hitPlayer;
        int mana, money;
        int lvl;
        int randomSkin;
        int timeKd, hpSave, secFreez;

        private void buttonShop_Click(object sender, EventArgs e)
        {
            buttonShop.Visible = false;
            buttonCancelShop.Visible = true;

            buttonHil.Visible = true;
            buttonFreez.Visible = true;
        }

        private void buttonCancelUp_Click(object sender, EventArgs e)
        {
            buttonUpgrade.Visible = true;
            buttonCancelUp.Visible = false;

            buttonUpLife.Visible = false;
            buttonUpHit.Visible = false;
        }

        private void buttonCancelShop_Click(object sender, EventArgs e)
        {
            buttonShop.Visible = true;
            buttonCancelShop.Visible = false;

            buttonHil.Visible = false;
            buttonFreez.Visible = false;
        }

        private void buttonUpHit_Click(object sender, EventArgs e)
        {
            if (mana >= 10)
            {
                if (hitPlayer == 20)
                {
                    MessageBox.Show("Атака прокачена на максимум");
                }
                else
                {
                    mana -= 10;
                    hitPlayer += 3;
                    labelHit.Text = hitPlayer.ToString();
                    labelMana.Text = mana.ToString();
                    MessageBox.Show("Атака увеличенна");
                }
            }
            else
            {
                MessageBox.Show("Не хватает маны");
            }
        }

        private void buttonUpLife_Click(object sender, EventArgs e)
        {
            if (mana >= 10)
            {
                if (maxHpPlayer == 100)
                {
                    MessageBox.Show("Здоровье прокачено на максимум");
                }
                else
                {
                    mana -= 10;
                    maxHpPlayer += 5;
                    labelLife.Text = labelLife.Text = $"{hpPlayer}/{maxHpPlayer}";
                    labelMana.Text = mana.ToString();
                    MessageBox.Show("Здоровье увеличенно");
                }
            }
            else
            {
                MessageBox.Show("Не хватает маны");
            }
        }

        private void buttonHil_Click(object sender, EventArgs e)
        {
            if (money >= 30)
            {
                if (hpPlayer == maxHpPlayer)
                {
                    MessageBox.Show("Здоровье максимально");
                }
                else
                {
                    money -= 30;
                    hpPlayer = maxHpPlayer;
                    labelLife.Text = labelLife.Text = $"{hpPlayer}/{maxHpPlayer}";
                    labelMoney.Text = money.ToString();
                    MessageBox.Show("Здоровье востановленно");
                }
            }
            else
            {
                MessageBox.Show("Не хватает золота");
            }
        }

        private void timerFreez_Tick(object sender, EventArgs e)
        {
            secFreez--;
            timerHitMonster.Enabled = false;
            labelFreez.Visible = true;

            if(secFreez == 0)
            {
                timerHitMonster.Enabled = false;
                timerFreez.Enabled = false;
                labelFreez.Visible = false;
            }
            else
            {
                labelFreez.Text = secFreez.ToString();
            }
        }

        private void buttonFreez_Click(object sender, EventArgs e)
        {
            if (money >= 40)
            {
                secFreez = 4;
                timerFreez.Enabled = true;
                money -= 40;
                labelMoney.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("Не хватает золота");
            }
        }

        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            buttonUpgrade.Visible = false;
            buttonCancelUp.Visible = true;

            buttonUpLife.Visible = true;
            buttonUpHit.Visible = true;
        }

        private void timerHitMonster_Tick(object sender, EventArgs e)
        {
            hitMonster = random.Next(2, 8 + 1);
            hpPlayer = hpPlayer - hitMonster;

            if (hpPlayer == 0 || hpPlayer < 0)
            {
                labelLife.Text = "0";
                hpPlayer = 0;
                timerHitMonster.Enabled = false;
                MessageBox.Show("Вы проиграли");
                this.Close();
            }

            labelLife.Text = $"{hpPlayer}/{maxHpPlayer}";
        }

        private void time_Tick(object sender, EventArgs e)
        {
            timeKd++;

            if (timeKd == 1)
            {
                buttonBeat.Visible = false;
                labelInfo.Visible = false;
                randomSkin = random.Next(0, 4 + 1);

                lvl++;

                maxHpMonster = maxHpMonster + random.Next(1, 5 + 1);
                hpMonster = maxHpMonster;
                
                switch (lvl)
                {
                    case 10:
                        labelBoss.Visible = true;
                        hpSave = maxHpMonster;
                        int hpBoss10 = 100;
                        hpMonster = hpBoss10;
                        maxHpMonster = hpBoss10;
                        break;
                    case 11:
                        labelBoss.Visible = false;
                        hpMonster = hpSave;
                        maxHpMonster = hpSave;
                        break;
                    case 20:
                        labelBoss.Visible = true;
                        hpSave = maxHpMonster;
                        int hpBoss20 = 150;
                        hpMonster = hpBoss20;
                        maxHpMonster = hpBoss20;
                        break;
                    case 21:
                        labelBoss.Visible = false;
                        hpMonster = hpSave;
                        maxHpMonster = hpSave;
                        break;
                    case 30:
                        labelBoss.Visible = true;
                        hpSave = maxHpMonster;
                        int hpBoss30 = 200;
                        hpMonster = hpBoss30;
                        maxHpMonster = hpBoss30;
                        break;
                    case 31:
                        labelBoss.Visible = false;
                        hpMonster = hpSave;
                        maxHpMonster = hpSave;
                        break;
                    case 40:
                        labelBoss.Visible = true;
                        hpSave = maxHpMonster;
                        int hpBoss40 = 250;
                        hpMonster = hpBoss40;
                        maxHpMonster = hpBoss40;
                        break;
                    case 41:
                        labelBoss.Visible = false;
                        hpMonster = hpSave;
                        maxHpMonster = hpSave;
                        break;
                    case 50:
                        labelBoss.Visible = true;
                        hpSave = maxHpMonster;
                        int hpBoss50 = 300;
                        hpMonster = hpBoss50;
                        maxHpMonster = hpBoss50;
                        break;
                    case 51:
                        labelInfo.Visible = false;
                        buttonBeat.Visible = false;
                        timerHitMonster.Enabled = false;
                        MessageBox.Show("Вы выграли");
                        this.Close();
                        break;
                }

                labelInfo.Text = $"[lvl{lvl}] {hpMonster}/{maxHpMonster}";
            }

            if (timeKd == 2)
            {
                buttonBeat.ImageIndex = randomSkin;
                buttonBeat.Visible = true;
                labelInfo.Visible = true;
                buttonBeat.Enabled = true;
                time.Enabled = false;
                timeKd = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomSkin = random.Next(0, 4 + 1);
            buttonBeat.ImageIndex = randomSkin;
            
            lvl = 1;

            mana = 0;
            money = 0;

            maxHpPlayer = 50;
            hpPlayer = maxHpPlayer;
            hitPlayer = 5;

            maxHpMonster = 35;
            hpMonster = 35;

            secFreez = 0;
        }

        private void buttonBeat_Click(object sender, EventArgs e)
        {
            hpMonster = hpMonster - hitPlayer;

            timerHitMonster.Enabled = true;

            if (hpMonster == 0 || hpMonster < 0)
            {
                buttonBeat.Enabled = false;

                hpMonster = 0;

                timerHitMonster.Enabled = false;
                time.Enabled = true;

                mana = mana + random.Next(1, 5 + 1);
                money = money + random.Next(1, 10 + 1);

                labelMana.Text = mana.ToString();
                labelMoney.Text = money.ToString();
            }

            labelInfo.Text = $"[lvl{lvl}] {hpMonster}/{maxHpMonster}";
        }
    }
}
