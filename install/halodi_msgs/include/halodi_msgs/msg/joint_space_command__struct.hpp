// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/JointSpaceCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_SPACE_COMMAND__STRUCT_HPP_
#define HALODI_MSGS__MSG__JOINT_SPACE_COMMAND__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'joint'
#include "halodi_msgs/msg/joint_name__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__JointSpaceCommand __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__JointSpaceCommand __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct JointSpaceCommand_
{
  using Type = JointSpaceCommand_<ContainerAllocator>;

  explicit JointSpaceCommand_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : joint(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->q_desired = 0.0;
      this->qd_desired = 0.0;
      this->qdd_desired = 0.0;
      this->derive_qd_desired = false;
      this->use_default_gains = false;
      this->stiffness = 0.0;
      this->damping = 0.0;
      this->motorDampingScale = 0.0;
      this->max_feedback = 0.0;
    }
  }

  explicit JointSpaceCommand_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : joint(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->q_desired = 0.0;
      this->qd_desired = 0.0;
      this->qdd_desired = 0.0;
      this->derive_qd_desired = false;
      this->use_default_gains = false;
      this->stiffness = 0.0;
      this->damping = 0.0;
      this->motorDampingScale = 0.0;
      this->max_feedback = 0.0;
    }
  }

  // field types and members
  using _joint_type =
    halodi_msgs::msg::JointName_<ContainerAllocator>;
  _joint_type joint;
  using _q_desired_type =
    double;
  _q_desired_type q_desired;
  using _qd_desired_type =
    double;
  _qd_desired_type qd_desired;
  using _qdd_desired_type =
    double;
  _qdd_desired_type qdd_desired;
  using _q_desired_filter_break_frequency_type =
    rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other>;
  _q_desired_filter_break_frequency_type q_desired_filter_break_frequency;
  using _derive_qd_desired_type =
    bool;
  _derive_qd_desired_type derive_qd_desired;
  using _use_default_gains_type =
    bool;
  _use_default_gains_type use_default_gains;
  using _stiffness_type =
    double;
  _stiffness_type stiffness;
  using _damping_type =
    double;
  _damping_type damping;
  using _motorDampingScale_type =
    double;
  _motorDampingScale_type motorDampingScale;
  using _max_feedback_type =
    double;
  _max_feedback_type max_feedback;

  // setters for named parameter idiom
  Type & set__joint(
    const halodi_msgs::msg::JointName_<ContainerAllocator> & _arg)
  {
    this->joint = _arg;
    return *this;
  }
  Type & set__q_desired(
    const double & _arg)
  {
    this->q_desired = _arg;
    return *this;
  }
  Type & set__qd_desired(
    const double & _arg)
  {
    this->qd_desired = _arg;
    return *this;
  }
  Type & set__qdd_desired(
    const double & _arg)
  {
    this->qdd_desired = _arg;
    return *this;
  }
  Type & set__q_desired_filter_break_frequency(
    const rosidl_generator_cpp::BoundedVector<double, 1, typename ContainerAllocator::template rebind<double>::other> & _arg)
  {
    this->q_desired_filter_break_frequency = _arg;
    return *this;
  }
  Type & set__derive_qd_desired(
    const bool & _arg)
  {
    this->derive_qd_desired = _arg;
    return *this;
  }
  Type & set__use_default_gains(
    const bool & _arg)
  {
    this->use_default_gains = _arg;
    return *this;
  }
  Type & set__stiffness(
    const double & _arg)
  {
    this->stiffness = _arg;
    return *this;
  }
  Type & set__damping(
    const double & _arg)
  {
    this->damping = _arg;
    return *this;
  }
  Type & set__motorDampingScale(
    const double & _arg)
  {
    this->motorDampingScale = _arg;
    return *this;
  }
  Type & set__max_feedback(
    const double & _arg)
  {
    this->max_feedback = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__JointSpaceCommand
    std::shared_ptr<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__JointSpaceCommand
    std::shared_ptr<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const JointSpaceCommand_ & other) const
  {
    if (this->joint != other.joint) {
      return false;
    }
    if (this->q_desired != other.q_desired) {
      return false;
    }
    if (this->qd_desired != other.qd_desired) {
      return false;
    }
    if (this->qdd_desired != other.qdd_desired) {
      return false;
    }
    if (this->q_desired_filter_break_frequency != other.q_desired_filter_break_frequency) {
      return false;
    }
    if (this->derive_qd_desired != other.derive_qd_desired) {
      return false;
    }
    if (this->use_default_gains != other.use_default_gains) {
      return false;
    }
    if (this->stiffness != other.stiffness) {
      return false;
    }
    if (this->damping != other.damping) {
      return false;
    }
    if (this->motorDampingScale != other.motorDampingScale) {
      return false;
    }
    if (this->max_feedback != other.max_feedback) {
      return false;
    }
    return true;
  }
  bool operator!=(const JointSpaceCommand_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct JointSpaceCommand_

// alias to use template instance with default allocator
using JointSpaceCommand =
  halodi_msgs::msg::JointSpaceCommand_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__JOINT_SPACE_COMMAND__STRUCT_HPP_
