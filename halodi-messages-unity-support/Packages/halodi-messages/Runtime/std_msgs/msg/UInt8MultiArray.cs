using System.Text;
namespace std_msgs.msg
{


/**
       * Please look at the MultiArrayLayout message definition for
       * documentation on all multiarrays.
       */
[System.Serializable]
public class UInt8MultiArray : Halodi.CDR.DataType<UInt8MultiArray>
{

	public Halodi.CDR.TopicDataType<UInt8MultiArray> Type => new UInt8MultiArrayPubSubType();
	
   /**
            * specification of data layout
            */
   public std_msgs.msg.MultiArrayLayout layout;
   /**
            * array of data
            */
   public System.Collections.Generic.List<byte> data;


   public void Set(UInt8MultiArray other)
   {
      std_msgs.msg.MultiArrayLayoutPubSubType.Copy(other.layout, layout);


      if(other.data == null)
      {
      	data = null;
      }
      else
      {
      	data = new System.Collections.Generic.List<byte>(other.data.Count);
      	for(int i1 = 0; i1 < other.data.Count; i1++)
      	{
         		data.Add(other.data[i1]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("UInt8MultiArray {");
      builder.Append("layout=");
      builder.Append(this.layout);      builder.Append(", ");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}