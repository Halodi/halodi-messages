using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "RegionOfInterest" defined in "RegionOfInterest.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from RegionOfInterest.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit RegionOfInterest.idl instead.
*
*/
public class RegionOfInterestPubSubType : Halodi.CDR.TopicDataType<RegionOfInterest>
{
   public override string Name => "sensor_msgs::msg::dds_::RegionOfInterest_";


   public static int getCdrSerializedSize(sensor_msgs.msg.RegionOfInterest data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.RegionOfInterest data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.RegionOfInterest data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_4(data.x_offset);

      cdr.write_type_4(data.y_offset);

      cdr.write_type_4(data.height);

      cdr.write_type_4(data.width);

      cdr.write_type_7(data.do_rectify);

   }

   public static void read(sensor_msgs.msg.RegionOfInterest data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.x_offset=cdr.read_type_4();
      	
      data.y_offset=cdr.read_type_4();
      	
      data.height=cdr.read_type_4();
      	
      data.width=cdr.read_type_4();
      	
      data.do_rectify=cdr.read_type_7();
      	

   }


	public override void Serialize(sensor_msgs.msg.RegionOfInterest data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.RegionOfInterest data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.RegionOfInterest data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.RegionOfInterest src, sensor_msgs.msg.RegionOfInterest target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.RegionOfInterest src, sensor_msgs.msg.RegionOfInterest target)
    {
    	Copy(src, target);
    }


}


}