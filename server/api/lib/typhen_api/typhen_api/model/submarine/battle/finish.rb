# This file was generated by typhen-api

module TyphenApi::Model::Submarine::Battle
  class Finish
    include Virtus.model(:strict => true)

    attribute :has_won, Boolean, :required => true
    attribute :finished_at, Integer, :required => true
  end
end