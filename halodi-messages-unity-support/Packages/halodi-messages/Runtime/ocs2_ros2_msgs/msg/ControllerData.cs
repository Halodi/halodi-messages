using System.Text;
namespace ocs2_ros2_msgs.msg
{


[System.Serializable]
public class ControllerData : Halodi.CDR.DataType<ControllerData>
{

	public Halodi.CDR.TopicDataType<ControllerData> Type => new ControllerDataPubSubType();
	
   public System.Collections.Generic.List<float> data;


   public void Set(ControllerData other)
   {

      if(other.data == null)
      {
      	data = null;
      }
      else
      {
      	data = new System.Collections.Generic.List<float>(other.data.Count);
      	for(int i1 = 0; i1 < other.data.Count; i1++)
      	{
         		data.Add(other.data[i1]);
      	}
      }   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ControllerData {");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}