public class MyList<T>
{
    public T[] items;
    public int Lenth;
    public MyList(params T[] items)
    {
        this.items = items;
        Lenth = this.items.Length;
    }


    public void Add(T item)
    {
        T[] temp = this.items;
        this.items = new T[Lenth + 1];

        for (int i = 0; i < this.Lenth; i++)
        {
            this.items[i] = temp[i];
        }
        this.items[this.Lenth] = item;
        this.Lenth += 1;
        

    }

    public void DeleteIndex(int index)
    {
        if (index < this.Lenth) 
        {
            T[] temp = this.items;
            this.items = new T[Lenth - 1];

            for (int i = 0, j = 0; i < this.Lenth; i++,j++)
            {
                if (index == i)
                {
                    j -= 1;
                    continue;
                    
                }
                else
                {
                    this.items[j] = temp[i];
                }

                
            }
            this.Lenth -= 1;

        }
        
        
       




    }
}