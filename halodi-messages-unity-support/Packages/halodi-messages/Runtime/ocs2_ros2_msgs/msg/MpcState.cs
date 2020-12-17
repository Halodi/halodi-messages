using System.Text;
namespace ocs2_ros2_msgs.msg
{


[System.Serializable]
public class MpcState : Halodi.CDR.DataType<MpcState>
{

	public Halodi.CDR.TopicDataType<MpcState> Type => new MpcStatePubSubType();
	
   public System.Collections.Generic.List<float> value;


   public void Set(MpcState other)
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

      builder.Append("MpcState {");
      builder.Append("value=");
      builder.Append(this.value);
      builder.Append("}");
      return builder.ToString();
   }
}


}