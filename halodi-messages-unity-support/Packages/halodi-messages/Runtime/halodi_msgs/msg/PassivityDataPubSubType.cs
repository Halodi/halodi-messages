using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "PassivityData" defined in "PassivityData.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from PassivityData.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit PassivityData.idl instead.
*
*/
public class PassivityDataPubSubType : Halodi.CDR.TopicDataType<PassivityData>
{
   public override string Name => "halodi_msgs::msg::dds_::PassivityData_";


   public static int getCdrSerializedSize(halodi_msgs.msg.PassivityData data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.PassivityData data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.PassivityData data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.energy_packet);

      cdr.write_type_6(data.energy_tank_level);

      cdr.write_type_6(data.virtual_mass);

      cdr.write_type_6(data.virtual_inertia);

   }

   public static void read(halodi_msgs.msg.PassivityData data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.energy_packet=cdr.read_type_6();
      	
      data.energy_tank_level=cdr.read_type_6();
      	
      data.virtual_mass=cdr.read_type_6();
      	
      data.virtual_inertia=cdr.read_type_6();
      	

   }


	public override void Serialize(halodi_msgs.msg.PassivityData data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.PassivityData data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.PassivityData data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.PassivityData src, halodi_msgs.msg.PassivityData target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.PassivityData src, halodi_msgs.msg.PassivityData target)
    {
    	Copy(src, target);
    }


}


}