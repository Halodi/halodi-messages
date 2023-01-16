using System.IO;
namespace ocs2_ros2_msgs.msg
{

/**
* 
* Topic data type of the struct "MpcInput" defined in "MpcInput.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MpcInput.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MpcInput.idl instead.
*
*/
public class MpcInputPubSubType : Halodi.CDR.TopicDataType<MpcInput>
{
   public override string Name => "ocs2_ros2_msgs::msg::dds_::MpcInput_";


   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcInput data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(ocs2_ros2_msgs.msg.MpcInput data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.value.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      return current_alignment - initial_alignment;
   }

   public static void write(ocs2_ros2_msgs.msg.MpcInput data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.value == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int value_length = data.value.Count;
            cdr.write_type_2(value_length);
            for (int i0 = 0; i0 < value_length; i0++)
            {
      			cdr.write_type_5(data.value[i0]);
            }
        }   }

   public static void read(ocs2_ros2_msgs.msg.MpcInput data, Halodi.CDR.CDRDeserializer cdr)
   {

      int value_length = cdr.read_type_2();
      data.value = new System.Collections.Generic.List<float>(value_length);
      for(int i = 0; i < value_length; i++)
      {
      	data.value.Add(cdr.read_type_5());
      	
      	
      }

      	

   }


	public override void Serialize(ocs2_ros2_msgs.msg.MpcInput data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(ocs2_ros2_msgs.msg.MpcInput data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(ocs2_ros2_msgs.msg.MpcInput data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(ocs2_ros2_msgs.msg.MpcInput src, ocs2_ros2_msgs.msg.MpcInput target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(ocs2_ros2_msgs.msg.MpcInput src, ocs2_ros2_msgs.msg.MpcInput target)
    {
    	Copy(src, target);
    }


}


}