public class Singleton {

    public static Singleton instance;
    private Singleton() {
      
    }
    string value = null;
    public static Singleton getInstance() {
        if(instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public string getValue() {
        return value;
    }

    public void setValue(string value){
        this.value = value;
    }
}