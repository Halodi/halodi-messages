using System.Text;
namespace std_msgs.msg
{


/**
       * Please look at the MultiArrayLayout message definition for
       * documentation on all multiarrays.
       */
[System.Serializable]
public class UInt64MultiArray : Halodi.CDR.DataType<UInt64MultiArray>
{

	public Halodi.CDR.TopicDataType<UInt64MultiArray> Type => new UInt64MultiArrayPubSubType();
	
   /**
            * specification of data layout
            */
   public std_msgs.msg.MultiArrayLayout layout;
   /**
            * array of data
            */
   public System.Collections.Generic.List<ulong> data;


   public void Set(UInt64MultiArray other)
   {
      std_msgs.msg.MultiArrayLayoutPubSubType.Copy(other.layout, layout);


      if(other.data == null)
      {
      	data = null;
      }
      else
      {
      	data = new System.Collections.Generic.List<ulong>(other.data.Count);
      	for(int i1 = 0; i1 < other.data.Count; i1++)
      	{
         		data.Add(other.data[i1]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("UInt64MultiArray {");
      builder.Append("layout=");
      builder.Append(this.layout);      builder.Append(", ");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}