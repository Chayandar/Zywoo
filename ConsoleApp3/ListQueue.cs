
    class ListQueue
    {
        class Element
        {
            public Person Data = null;
            public Element next = null;
        }
        Element head = null;
        public void add(Person p)
        {
            Element e = new();
            e.Data = p;
            if (head == null)
                head = e;
            else
            {
                Element t = head;
                while (t.next != null)
                {
                    t = t.next;
                    t.next = e;
                }
            }
        }
        public Person get()
        {
            if (head == null)
                return null;
            Person t = head.Data;
            head = head.next;
            return t;
        }
    }

