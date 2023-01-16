using System.IO;
namespace rosgraph_msgs.msg
{

/**
* 
* Topic data type of the struct "Clock" defined in "Clock.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Clock.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Clock.idl instead.
*
*/
public class ClockPubSubType : Halodi.CDR.TopicDataType<Clock>
{
   public override string Name => "rosgraph_msgs::msg::dds_::Clock_";


   public static int getCdrSerializedSize(rosgraph_msgs.msg.Clock data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rosgraph_msgs.msg.Clock data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += builtin_interfaces.msg.TimePubSubType.getCdrSerializedSize(data.clock, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(rosgraph_msgs.msg.Clock data, Halodi.CDR.CDRSerializer cdr)
   {
      builtin_interfaces.msg.TimePubSubType.write(data.clock, cdr);
   }

   public static void read(rosgraph_msgs.msg.Clock data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.clock = builtin_interfaces.msg.TimePubSubType.Create();
      builtin_interfaces.msg.TimePubSubType.read(data.clock, cdr);
      	

   }


	public override void Serialize(rosgraph_msgs.msg.Clock data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(rosgraph_msgs.msg.Clock data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(rosgraph_msgs.msg.Clock data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(rosgraph_msgs.msg.Clock src, rosgraph_msgs.msg.Clock target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(rosgraph_msgs.msg.Clock src, rosgraph_msgs.msg.Clock target)
    {
    	Copy(src, target);
    }


}


}