using System.Text;
namespace ocs2_ros2_msgs.msg
{


[System.Serializable]
public class MpcInput : Halodi.CDR.DataType<MpcInput>
{

	public Halodi.CDR.TopicDataType<MpcInput> Type => new MpcInputPubSubType();
	
   public System.Collections.Generic.List<float> value;


   public void Set(MpcInput other)
   {

      if(other.value == null)
      {
      	value = null;
      }
      else
      {
      	value = new System.Collections.Generic.List<float>(other.value.Count);
      	for(int i1 = 0; i1 < other.value.Count; i1++)
      	{
         		value.Add(other.value[i1]);
      	}
      }   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MpcInput {");
      builder.Append("value=");
      builder.Append(this.value);
      builder.Append("}");
      return builder.ToString();
   }
}


}