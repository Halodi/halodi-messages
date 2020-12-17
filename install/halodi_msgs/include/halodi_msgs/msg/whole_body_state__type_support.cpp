// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/WholeBodyState.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/whole_body_state__struct.hpp"
#include "rosidl_typesupport_introspection_cpp/field_types.hpp"
#include "rosidl_typesupport_introspection_cpp/identifier.hpp"
#include "rosidl_typesupport_introspection_cpp/message_introspection.hpp"
#include "rosidl_typesupport_introspection_cpp/message_type_support_decl.hpp"
#include "rosidl_typesupport_introspection_cpp/visibility_control.h"

namespace halodi_msgs
{

namespace msg
{

namespace rosidl_typesupport_introspection_cpp
{

void WholeBodyState_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::WholeBodyState(_init);
}

void WholeBodyState_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::WholeBodyState *>(message_memory);
  typed_message->~WholeBodyState();
}

size_t size_function__WholeBodyState__imu_measurements(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::ImuMeasurement> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyState__imu_measurements(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::ImuMeasurement> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyState__imu_measurements(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::ImuMeasurement> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyState__imu_measurements(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::ImuMeasurement> *>(untyped_member);
  member->resize(size);
}

size_t size_function__WholeBodyState__joint_states(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::JointMeasurement> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyState__joint_states(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::JointMeasurement> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyState__joint_states(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::JointMeasurement> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyState__joint_states(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::JointMeasurement> *>(untyped_member);
  member->resize(size);
}

size_t size_function__WholeBodyState__taskspace_feedback(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::TaskSpaceFeedback> *>(untyped_member);
  return member->size();
}

const void * get_const_function__WholeBodyState__taskspace_feedback(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::TaskSpaceFeedback> *>(untyped_member);
  return &member[index];
}

void * get_function__WholeBodyState__taskspace_feedback(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::TaskSpaceFeedback> *>(untyped_member);
  return &member[index];
}

void resize_function__WholeBodyState__taskspace_feedback(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::TaskSpaceFeedback> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember WholeBodyState_message_member_array[11] = {
  {
    "header",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<std_msgs::msg::Header>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, header),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "last_received_sequence_id",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_INT32,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, last_received_sequence_id),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "controller_state",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_STRING,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, controller_state),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "current_balance_mode",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::BalanceMode>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, current_balance_mode),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "robot_status",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, robot_status),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "pose",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Pose>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, pose),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "angular_velocity",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, angular_velocity),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "linear_velocity",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<geometry_msgs::msg::Vector3>(),  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, linear_velocity),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "imu_measurements",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::ImuMeasurement>(),  // members of sub message
    true,  // is array
    2,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, imu_measurements),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyState__imu_measurements,  // size() function pointer
    get_const_function__WholeBodyState__imu_measurements,  // get_const(index) function pointer
    get_function__WholeBodyState__imu_measurements,  // get(index) function pointer
    resize_function__WholeBodyState__imu_measurements  // resize(index) function pointer
  },
  {
    "joint_states",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::JointMeasurement>(),  // members of sub message
    true,  // is array
    25,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, joint_states),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyState__joint_states,  // size() function pointer
    get_const_function__WholeBodyState__joint_states,  // get_const(index) function pointer
    get_function__WholeBodyState__joint_states,  // get(index) function pointer
    resize_function__WholeBodyState__joint_states  // resize(index) function pointer
  },
  {
    "taskspace_feedback",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::TaskSpaceFeedback>(),  // members of sub message
    true,  // is array
    5,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs::msg::WholeBodyState, taskspace_feedback),  // bytes offset in struct
    nullptr,  // default value
    size_function__WholeBodyState__taskspace_feedback,  // size() function pointer
    get_const_function__WholeBodyState__taskspace_feedback,  // get_const(index) function pointer
    get_function__WholeBodyState__taskspace_feedback,  // get(index) function pointer
    resize_function__WholeBodyState__taskspace_feedback  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers WholeBodyState_message_members = {
  "halodi_msgs::msg",  // message namespace
  "WholeBodyState",  // message name
  11,  // number of fields
  sizeof(halodi_msgs::msg::WholeBodyState),
  WholeBodyState_message_member_array,  // message members
  WholeBodyState_init_function,  // function to initialize message memory (memory has to be allocated)
  WholeBodyState_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t WholeBodyState_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &WholeBodyState_message_members,
  get_message_typesupport_handle_function,
};

}  // namespace rosidl_typesupport_introspection_cpp

}  // namespace msg

}  // namespace halodi_msgs


namespace rosidl_typesupport_introspection_cpp
{

template<>
ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
get_message_type_support_handle<halodi_msgs::msg::WholeBodyState>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::WholeBodyState_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, WholeBodyState)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::WholeBodyState_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
