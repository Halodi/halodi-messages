using System.Text;
namespace std_msgs.msg
{


/**
       * Please look at the MultiArrayLayout message definition for
       * documentation on all multiarrays.
       */
[System.Serializable]
public class Float64MultiArray : Halodi.CDR.DataType<Float64MultiArray>
{

	public Halodi.CDR.TopicDataType<Float64MultiArray> Type => new Float64MultiArrayPubSubType();
	
   /**
            * specification of data layout
            */
   public std_msgs.msg.MultiArrayLayout layout;
   /**
            * array of data
            */
   public System.Collections.Generic.List<double> data;


   public void Set(Float64MultiArray other)
   {
      std_msgs.msg.MultiArrayLayoutPubSubType.Copy(other.layout, layout);


      if(other.data == null)
      {
      	data = null;
      }
      else
      {
      	data = new System.Collections.Generic.List<double>(other.data.Count);
      	for(int i1 = 0; i1 < other.data.Count; i1++)
      	{
         		data.Add(other.data[i1]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Float64MultiArray {");
      builder.Append("layout=");
      builder.Append(this.layout);      builder.Append(", ");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}