using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "UInt8" defined in "UInt8.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from UInt8.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit UInt8.idl instead.
*
*/
public class UInt8PubSubType : Halodi.CDR.TopicDataType<UInt8>
{
   public override string Name => "std_msgs::msg::dds_::UInt8_";


   public static int getCdrSerializedSize(std_msgs.msg.UInt8 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.UInt8 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.UInt8 data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.data);

   }

   public static void read(std_msgs.msg.UInt8 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_9();
      	

   }


	public override void Serialize(std_msgs.msg.UInt8 data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(std_msgs.msg.UInt8 data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(std_msgs.msg.UInt8 data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(std_msgs.msg.UInt8 src, std_msgs.msg.UInt8 target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(std_msgs.msg.UInt8 src, std_msgs.msg.UInt8 target)
    {
    	Copy(src, target);
    }


}


}