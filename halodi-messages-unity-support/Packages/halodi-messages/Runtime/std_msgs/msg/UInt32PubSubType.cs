using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "UInt32" defined in "UInt32.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from UInt32.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit UInt32.idl instead.
*
*/
public class UInt32PubSubType : Halodi.CDR.TopicDataType<UInt32>
{
   public override string Name => "std_msgs::msg::dds_::UInt32_";


   public static int getCdrSerializedSize(std_msgs.msg.UInt32 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.UInt32 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.UInt32 data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_4(data.data);

   }

   public static void read(std_msgs.msg.UInt32 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_4();
      	

   }


	public override void Serialize(std_msgs.msg.UInt32 data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(std_msgs.msg.UInt32 data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(std_msgs.msg.UInt32 data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(std_msgs.msg.UInt32 src, std_msgs.msg.UInt32 target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(std_msgs.msg.UInt32 src, std_msgs.msg.UInt32 target)
    {
    	Copy(src, target);
    }


}


}