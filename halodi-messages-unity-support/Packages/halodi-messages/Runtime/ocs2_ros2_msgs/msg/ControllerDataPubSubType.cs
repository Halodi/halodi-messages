using System.IO;
namespace ocs2_ros2_msgs.msg
{

/**
* 
* Topic data type of the struct "ControllerData" defined in "ControllerData.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ControllerData.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ControllerData.idl instead.
*
*/
public class ControllerDataPubSubType : Halodi.CDR.TopicDataType<ControllerData>
{
   public override string Name => "ocs2_ros2_msgs::msg::dds_::ControllerData_";


   
   public override void serialize(ocs2_ros2_msgs.msg.ControllerData data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, ocs2_ros2_msgs.msg.ControllerData data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.ControllerData data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.ControllerData data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.data.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      return current_alignment - initial_alignment;
   }

   public static void write(ocs2_ros2_msgs.msg.ControllerData data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.data == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int data_length = data.data.Count;
            cdr.write_type_2(data_length);
            for (int i0 = 0; i0 < data_length; i0++)
            {
      			cdr.write_type_5(data.data[i0]);
            }
        }   }

   public static void read(ocs2_ros2_msgs.msg.ControllerData data, Halodi.CDR.CDRDeserializer cdr)
   {

      int data_length = cdr.read_type_2();
      data.data = new System.Collections.Generic.List<float>(data_length);
      for(int i = 0; i < data_length; i++)
      {
      	data.data.Add(cdr.read_type_5());
      	
      	
      }

      	

   }


    public static void Copy(ocs2_ros2_msgs.msg.ControllerData src, ocs2_ros2_msgs.msg.ControllerData target)
    {
        target.Set(src);
    }


}


}