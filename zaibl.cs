using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zaibl : MonoBehaviour
{
  public TextMesh text;
  public GameObject objText;
  float DMG = 3f;

    // Start is called before the first frame update
    void Start()
    {
        //text.text = "dsdsdasdadsa";
      Invoke("Privet",4f);
    }

    void Privet()
    {
      text.text = "Ты попал сюда *** пойми как,\n *** пойми зачем.";
      Invoke("Privet2",4f);
    }
    void Privet2()
    {
      text.text = "Читай и запоминай! \nОколо стены, рядом с требушетами \nесть сундук там найдешь вкусняху";
      Invoke("Privet3",6f);
    }


    void Privet3()
    {
      text.text = "Но не попадись этим уродам! \n Загрызут и не заметят!!!";
      FindObjectOfType<dude>().GOGO();
      Invoke("DiologOff",4f);
    }
    public void Find()
    {
      DiologOn();
      text.text ="Красава, теперь на правую кнопку \n ты можешь кидать в них корбки!";
      Invoke("Find1",4f);
    }
    void Find1()
    {
      text.text = "И не удевляйся такому звуку";
      Invoke("Find1_1",3f);
    }
    void Find1_1()
    {
      text.text = "Если ты хочешь ВЫЖИТЬ,\n то тебе следует зачистить этот\n город";
      Invoke("Find1_2",5f);
    }
    void Find1_2()
    {
      text.text = "Дам намёк, на ещё одну способность,\n за одними из ворот,\nесть ещё один сундучок";
      Invoke("Find1_3",7f);
    }
    public void Find2()
    {
      DiologOn();
      text.text ="А ты не так прост,\nтеперь ты можешь их просто месить\n(с задержкой в 5 секунд)\nна букву F или А как тебе удобней.";
      Invoke("DiologOff",8f);
    }
    void Find1_3()
    {
      text.text ="Кстати, не знаю зачем тебе это знать,\n но на Q ты можешь смотреть\n по вертикали.";
      Invoke("DiologOff",6f);
    }



    public void Dead()
    {
      DiologOn();
      text.text = "Ты сдох, хахахах.\n \n Твой основной урон состовляет \n"+DMG+"-0.5 = "+(DMG-0.5f);
      Invoke("DiologOff",6f);
    }

    public void Search()
    {
    	DiologOn();
    	text.text = "Вот какраз, где тут и завалялась \nданная способность.";
    	Invoke("Search_2",4f);
    }
    void Search_2()
    {
    	text.text = "И раз на то пошло,пока ты ищешь,\n расскажу про этих димонов";
    	Invoke("Search_3",4f);
    }
    void Search_3()
    {
    	text.text = "Смотри, у них, есть глава.(Ты его узнаешь)\nИ эта глава использует магию\n \"Моего идеально написанного кода\"";
    	Invoke("Search_4",6f);
    }
    void Search_4()
    {
    	text.text = "Каварная магия, не поспоришь.\nОна заключаеться в том,\nчто ворует жизнь у прихвостней.";
    	Invoke("Search_5",6f);
    }
    void Search_5()
    {
    	text.text = "Кратко говоря, тебе придётся перебить их всех,\nперед убийством их босса\n(у прихвостней также) *шепотом*";
    	Invoke("DiologOff",6f);
    }
    void DiologOff()
    {
      gameObject.SetActive(false);
    }  
    void DiologOn()
    {
      gameObject.SetActive(true);
    } 
}
